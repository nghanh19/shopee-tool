using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeeTool
{
    public static class Utils
    {
        private static readonly string[] FirstNames = new string[] {
            "Cara",
"Duyen",
"Hong",
"Khanh",
"Kieu",
"Lan",
"Lieu",
"Linh",
"Loan",
"Ly",
"Mai",
"Mychau",
"Nguyet",
"Nhi",
"Nhu",
"Nhung",
"Nu",
"Sen",
"Tai",
"Tam",
"Tan",
"Thao",
"Thuy",
"Tien",
"Trang",
"Trinh",
"Tuyen",
"Ut",
"Xuan",
"Chung",
"Dong",
"Duy",
"Gan",
"Keemo",
"Lam",
"Laman",
"Long",
"Phuoc",
"Phuong",
"Quan",
"QuanVan",
"QuangTu",
"Ritchell",
"So",
"Tai",
"Thai",
"Thong",
"Tinh",
"Tong",
"Viet",
"Vui",
"Yen"
        };
        private static readonly string[] LastNames = new string[] {
"Kieu",
"Lac",
"Lai",
"Lam",
"Lang",
"Lavan",
"Lien",
"Lieu",
"Loi",
"Luc",
"Luong",
"Luu",
"Mac",
"Mach",
"Mai",
"Minh",
"Nghiem",
"Ngo",
"Nguy",
"Nguyen",
"Nhan",
"Nzuyen",
"Ong",
"Pham",
"Phan",
"Phang",
"Pho",
"Phong",
"Phu",
"Phung",
"Phuong",
"Quach",
"Quang",
"Tang",
"Tat",
"Thach",
"Thai",
"Tham",
"Than",
"Thang",
"Thanh",
"Banh",
"Bien",
"Bui",
"Cam",
"Can",
"Cao",
"Chan",
"Chau",
"Che",
"Chiem",
"Chuong",
"Cong",
"Dai",
"Dam",
"Dan",
"Dang",
"Danh",
"Dao",
"Dau",
"Diep",
"Dieu",
"Dinh",
"Dinn",
"Doan",
"Don",
"Dong",
"Dung",
"Duong",
"Giang",
"Hai",
"Hang",
"Hau",
"Hoang",
"Hua",
"Hue",
"Huynh",
"Kha",
"Khong",
"Khuu",
"Kien"
        };
        public static Random rdFirst = new Random();
        public static Random rdLast = new Random();
        public static Random rdYear = new Random();
        public static Random rdMonth = new Random();
        public static Random rdPassword = new Random();
        public static string RandomUsername()
        {
            int firstIndex = rdFirst.Next(FirstNames.Length);
            int rdLast = rdFirst.Next(LastNames.Length);

            string year = rdYear.Next(1980, 2005).ToString();
            string month = rdMonth.Next(1, 12).ToString().PadLeft(2, '0');
            return FirstNames[firstIndex] + LastNames[rdLast] + month + year;
        }

        public static string RandomPassword()
        {
            const string chars = "abcdeghiklmnopqrstuvxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[rdPassword.Next(s.Length)]).ToArray());
        }

        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
        {
            while (source.Any())
            {
                yield return source.Take(chunksize);
                source = source.Skip(chunksize);
            }
        }
    }
}
