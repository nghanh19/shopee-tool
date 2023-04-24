using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeTool
{
    public class ByCaptchaHelper
    {
        private string APIKEY { get; set; }
        public ByCaptchaHelper(string apikey)
        {
            this.APIKEY = apikey;
        }
        public string ResolveCaptcha(string base64)
        {
            using (HttpClient client = new HttpClient())
            {
                Dictionary<string, string> keyValue = new Dictionary<string, string>();
                keyValue.Add("imagebase64", base64.Replace("\r", string.Empty).Replace("\n", string.Empty));
                keyValue.Add("key", APIKEY);
                keyValue.Add("server", "1");
                keyValue.Add("png_fixed", "0");
                HttpContent content = new FormUrlEncodedContent(keyValue);
                var request = client.PostAsync("http://api.bycaptcha.com", content).Result;
                if(request.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = request.Content.ReadAsStringAsync().Result;
                    var response = JsonConvert.DeserializeObject<ByCaptchaResponse>(json);
                    if(response != null)
                    {
                        if(response.status == "ok")
                        {
                            return response.textdecode;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }

    public class ByCaptchaResponse
    {
        public string status { get; set; }
        public string textdecode { get; set; }
    }
}
