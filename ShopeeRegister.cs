using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeTool
{
    public class RegisterInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HasPass
        {
            get
            {
                if (!string.IsNullOrEmpty(Password))
                {
                    byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(Password));
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int index = 0; index < hash.Length; ++index)
                        stringBuilder.Append(hash[index].ToString("x2"));


                    string md5 = stringBuilder.ToString();
                    StringBuilder Sb = new StringBuilder();
                    using (SHA256 hash256 = SHA256Managed.Create())
                    {
                        Encoding enc = Encoding.ASCII;
                        Byte[] result = hash256.ComputeHash(enc.GetBytes(md5));
                        foreach (Byte b in result)
                            Sb.Append(b.ToString("x2"));
                    }
                    return Sb.ToString();

                }
                return string.Empty;
            }
        }
        public string ProxyInfo { get; set; }
        public RegisterResult State { get; set; }
        public bool Finish = false;
    }
    public class ShopeeRegister
    {
        private HttpClient Client { get; set; }
        private HttpClientHandler Handler { get; set; }

        private RegisterInfo RegisterInfo { get; set; }
        private void InitHandler(string session = "", string countryCode = "")
        {
            try
            {
                Handler = new HttpClientHandler();
                Handler.CookieContainer = new CookieContainer();
                Handler.AllowAutoRedirect = false;
                Handler.UseCookies = true;
                Handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.None;
                Handler.UseCookies = true;
                var webProxy = new WebProxy("session-" + session + ".zproxy.lum-superproxy.io:22225")
                {
                    Credentials = new NetworkCredential("lum-customer-hl_6dd1e682-zone-zone1" + (countryCode != "" ? "-country-" + countryCode : ""), "4oorttsu4wwl"),
                };
                Handler.UseProxy = true;
                Handler.Proxy = webProxy;
            }
            catch
            {
            }
        }

        public RegisterResult Register(RegisterInfo registerInfo, string countryCode = "")
        {
            try
            {
                RegisterInfo = registerInfo;
                string SessionID = Guid.NewGuid().ToString().Replace("-", string.Empty);
                IPHostEntry hostInfo = Dns.GetHostEntry("session-" + SessionID + ".zproxy.lum-superproxy.io");

                InitHandler(SessionID, countryCode);
                Client = new HttpClient(Handler);
                registerInfo.ProxyInfo = JObject.Parse(Client.GetAsync("https://api.ipify.org?format=json").Result.Content.ReadAsStringAsync().Result).SelectToken("ip").Value<string>();
                string csrftoken = Guid.NewGuid().ToString().Replace("-", string.Empty);
                Handler.CookieContainer.Add(new Uri("https://shopee.vn"), new Cookie("csrftoken", csrftoken));
                var request = Client.GetAsync("https://shopee.vn/buyer/login/email/signup/?__classic__=1").Result;
                if (request.StatusCode == HttpStatusCode.OK)
                {
                    Client.DefaultRequestHeaders.TryAddWithoutValidation("Referer", "https://shopee.vn/buyer/login/email/signup/?__classic__=1");
                    string unique = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
                    request = Client.GetAsync("https://shopee.vn/api/v0/captcha?" + unique).Result;

                    if (request.StatusCode == HttpStatusCode.OK)
                    {
                        byte[] imgByte = request.Content.ReadAsByteArrayAsync().Result;
                        var base64string = Convert.ToBase64String(imgByte);
                        string captcha = new ByCaptchaHelper("count_6cbfd15de4951d6a6dac521a56a43de6").ResolveCaptcha(base64string);
                        if (!string.IsNullOrEmpty(captcha))
                        {
                            Client.DefaultRequestHeaders.TryAddWithoutValidation("Origin", "https://shopee.vn");
                            Client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
                            Client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");
                            Dictionary<string, string> postData = new Dictionary<string, string>();
                            postData.Add("csrfmiddlewaretoken", csrftoken);
                            postData.Add("email", RegisterInfo.Email);
                            postData.Add("username", RegisterInfo.Username);
                            postData.Add("password_hash", RegisterInfo.HasPass);
                            postData.Add("captcha", captcha);

                            HttpContent content = new FormUrlEncodedContent(postData);
                            request = Client.PostAsync("https://shopee.vn/buyer/login/email/signup/?method=post", content).Result;
                            string response = request.Content.ReadAsStringAsync().Result;
                            if (!response.Contains("{\"error\":1}"))
                            {
                                string captChaKey = Guid.NewGuid().ToString().Replace("-", string.Empty);
                                string cookieStr = captChaKey.Substring(0, 8) + "-" + captChaKey.Substring(8, 4) + "-" + captChaKey.Substring(12, 4)
                                    + "-" + captChaKey.Substring(16, 4) + "-" + captChaKey.Substring(20, 12);
                                bool Ok = false;
                                for (int index = 0; index < 4 & !Ok; ++index)
                                {
                                    try
                                    {
                                        request = Client.GetAsync("https://banhang.shopee.vn/account/signin").Result;
                                        if (request.StatusCode == HttpStatusCode.OK)
                                        {

                                            content = new MultipartFormDataContent();
                                            ((MultipartFormDataContent)content).Add(new StringContent(""), "captcha");
                                            ((MultipartFormDataContent)content).Add(new StringContent(captChaKey), "captcha_key");
                                            ((MultipartFormDataContent)content).Add(new StringContent("false"), "remember");
                                            ((MultipartFormDataContent)content).Add(new StringContent(RegisterInfo.HasPass), "password_hash");
                                            ((MultipartFormDataContent)content).Add(new StringContent(RegisterInfo.Username), "username");

                                            Client.DefaultRequestHeaders.Referrer = new Uri("https://banhang.shopee.vn/account/signin");
                                            Client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                                            request = Client.PostAsync("https://banhang.shopee.vn/api/v2/login/?SPC_CDS=" + cookieStr + "&SPC_CDS_VER=2", content).Result;
                                            if (request.StatusCode == HttpStatusCode.OK)
                                            {
                                                //response = request.Content.ReadAsStringAsync().Result;
                                                Client.DefaultRequestHeaders.Remove("Origin");
                                                Client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/plain");
                                                Client.DefaultRequestHeaders.TryAddWithoutValidation("Origin", "https://banhang.shopee.vn");
                                                Client.DefaultRequestHeaders.Referrer = new Uri("https://banhang.shopee.vn/portal/settings/shop/general");
                                                request = Client.PostAsync("https://banhang.shopee.vn/api/v3/settings/update_shop_setting/?SPC_CDS=" + cookieStr + "&SPC_CDS_VER=2",
                                                    new StringContent("{\"disable_new_device_login_otp\":true}")).Result;
                                                response = request.Content.ReadAsStringAsync().Result;
                                                if (response.Contains("{\"message\": \"success\", \"code\": 0, \"user_message\": \"success\"}"))
                                                    return RegisterResult.Successfully;
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        Ok = false;
                                    }
                                }
                                return RegisterResult.Error;
                            }
                            else return RegisterResult.CaptchaError;
                        }
                        else return RegisterResult.CaptchaError;
                    }
                    else return RegisterResult.CaptchaError;
                }
                return RegisterResult.Error;
            }
            catch
            {
                return RegisterResult.Error;
            }
            finally
            {
                registerInfo.Finish = true;
            }
        }
    }
    public enum RegisterResult
    {
        Idle,
        OnRegistering,
        CaptchaError,
        Successfully,
        Error
    }
}
