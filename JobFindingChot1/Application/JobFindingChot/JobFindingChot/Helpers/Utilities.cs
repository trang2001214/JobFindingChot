using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobFindingChot.Helpers
{
    public static class Utilities
    {
        /*
        public static string RemoveLinks(string html)
        {

        }
        public static string StripHTML(string input)
        {

        }
        public static string string Right(string value, int length)
        {

        }*/
        public static int GetFileSize(string urlfile)
        {
            int sizeFile = 0;
            try
            {
                Uri uriPath = new Uri(urlfile);
                var webRequest = HttpWebRequest.Create(uriPath);
                webRequest.Method = "HEAD";
                using (var webResponse = webRequest.GetResponse())
                {
                    var fileSize = webRequest.Headers.Get("Content-Length");
                    var fileSizeInMegaByte = Math.Round(Convert.ToDouble(fileSize) / 1024.0 / 1024.0, 2);
                    sizeFile = Convert.ToInt32(fileSizeInMegaByte);
                    //return fileSizeInMegaByte + "MB"
                }
            }
            catch
            {
                return sizeFile;
            }
            return sizeFile;
        }
        public static string ToTitleCase(string str)
        {
            string result = str;
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' ');
                for (int index = 0; index < words.Length; index++)
                {
                    var s = words[index];
                    if (s.Length > 0)
                    {
                        words[index] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }
        public static bool KiemTraHoVaTen(string input)
        {
            bool resutlts = false;
            try
            {
                Match match = Regex.Match(input, @"(\d+)");
                if (match.Success)
                {
                    var numer = int.Parse(match.Groups[1].Value);
                    return true;
                }
            }
            catch
            {
                return true;
            }
            return resutlts;
        }
        public static bool IsInteger(string str)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            try
            {
                if (String.IsNullOrWhiteSpace(str))
                {
                    return false;
                }
                if (!regex.IsMatch(str))
                {
                    return false;
                }
                return true;
            }
            catch
            {

            }
            return false;
        }
        public static bool IsNumber(this string aNumber)
        {
            BigInteger temp_big_int;
            var is_number = BigInteger.TryParse(aNumber, out temp_big_int);
            return is_number;
        }

        public static string GetDomain(string url)
        {
            string host = "";
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    Uri myUri = new Uri(url.Trim().ToLower());
                    host = myUri.Host.ToLower();
                }
            }
            catch
            {
                host = "";
            }
            return host;
        }
        public static int PAGE_SIZE = 20;
        public static string SEOUrl(string url)
        {
            url = url.ToLower();
            url = Regex.Replace(url, @"[áàạảãâấầậẩẫăắằặẳẵ]", "a");
            url = Regex.Replace(url, @"[éèẹẻẽếềệểễ]", "e");
            url = Regex.Replace(url, @"[ú ù ụ ủ ũ ứ ừ ự ử ữ]", "u");
            url = Regex.Replace(url, @"[óòọỏõốồộổỗớờợởỡ]", "o");
            url = Regex.Replace(url, @"[íìịỉĩ]", "i");
            url = Regex.Replace(url, @"[ýỳỵỷỹ]", "y");
            url = Regex.Replace(url, @"[đ]", "d");
            //Chỉ cho phép nhận: [^0-9a-z-\s]
            url = Regex.Replace(url.Trim(), @"[^0-9a-z-\s]", "").Trim();
            //Xử lý nhiều hơn 1 khoảng trắng -> 1kt
            url = Regex.Replace(url.Trim(), @"\s+", "-");
            //Thay khoảng trắng bằng -
            url = Regex.Replace(url, @"\s", "-");
            while (true)
            {
                if (url.IndexOf("--") != -1)
                {
                    url = url.Replace("--", "-");
                }
                else
                {
                    break;
                }
            }
            return url;
        }
        public static string GetRandomKey(int length = 5)
        {
            //Chuỗi mẫu
            string pattern = @"0123456789zxcvbnmasdfghjklqwertyuiop[]{}:~!@#$%^&*()+";
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }
            return sb.ToString();
        }
        public static async Task<string> UploadFile(Microsoft.AspNetCore.Http.IFormFile file, string sDirectory, string newname = null)
        {
            try
            {
                if (newname == null) newname = file.FileName;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sDirectory, newname);
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sDirectory);
                if (!System.IO.Directory.Exists(path2))
                {
                    System.IO.Directory.CreateDirectory(path2);
                }
                var supportedTypes = new[] { "jpg", "jpeg", "png", "gif" };
                var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                if (!supportedTypes.Contains(fileExt.ToLower()))
                {
                    return null;
                }
                else
                {
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return newname;
                }
            }
            catch
            {
                return null;
            }
        }
        public static async Task UploadFileToFolderImages(Microsoft.AspNetCore.Http.IFormFile file, string newname)
        {
            {
                try
                {
                    if (string.IsNullOrEmpty(newname)) newname = file.FileName;
                    var text = Directory.GetCurrentDirectory();
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", newname);
                    string folderImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                    if (!System.IO.Directory.Exists(folderImage))
                    {
                        System.IO.Directory.CreateDirectory(folderImage);
                    }
                    var supportedTypes = new[] { "jpg", "jpeg", "png", "gif" };
                    var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                    if (!supportedTypes.Contains(fileExt.ToLower()))//Khác các file định nghĩa
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                    }
                }
                catch
                {
                }
            }
        }
        public static async Task<string> UploadFileDocument(Microsoft.AspNetCore.Http.IFormFile file, string sDirectory, string newname = null)
        {
            {
                try
                {
                    if (newname == null) newname = file.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "5771fac5c1406cabdc911e584df9ab2d", sDirectory, newname);
                    string path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "5771fac5c1406cabdc911e584df9ab2d", sDirectory);
                    if (!System.IO.Directory.Exists(path2))
                    {
                        System.IO.Directory.CreateDirectory(path2);
                    }
                    var supportedTypes = new[] { "jpg", "jpeg", "png", "gif", "pdf", "docx", "doc" };
                    var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                    if (!supportedTypes.Contains(fileExt.ToLower()))//Khác các file định nghĩa
                    {
                        return null;
                    }
                    else
                    {
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        return newname;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
        public static void Great_folder(string link)
        {
            string path = link;
            if (!Directory.Exists(@path))
            {
                Directory.CreateDirectory(@path);
            }
        }
        public static string RandTime()
        {
            Random r = new Random();
            string rand = DateTime.Now.ToString().Replace("/", ":").Replace(":", "-").Replace(" ", "-").ToLower();
            rand = rand + r.Next(100, 999);
            return rand;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static List<string> ExtractLink(string html)
        {
            List<string> list = new List<string>();
            Regex regex = new Regex("(?:href|src)=[\"|'|]?(.*?)[\"|'|>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
            if (regex.IsMatch(html))
            {
                foreach (Match match in regex.Matches(html))
                {
                    list.Add(match.Groups[1].Value);
                }
            }
            return list;
        }
        //password+salt ==>md5==>string<== db
    }
}
