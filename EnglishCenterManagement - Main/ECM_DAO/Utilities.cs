using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;
using System.Text.RegularExpressions;

namespace ECM_DAO
{
    public class Utilities
    {
        public static string GetMD5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }
            return sbHash.ToString();
        }
        public static string ConvertToString(string p, string forNull = "")
        {
            if (p == null || p.ToString().Trim().Equals("NULL") || p == string.Empty)
            {
                return forNull;
            }
            return p;
        }
        public static bool IsValidEmail(string email)
        {
            const string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                     + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                     + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase).IsMatch(email);
        }

    }

}
