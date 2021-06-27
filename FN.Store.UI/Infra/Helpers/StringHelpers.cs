using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Infra.Helpers
{
    public static class StringHelpers
    {
        public static  string Encrypt( this string senha)
        {
            var salt = "|85D482E7AE1849A5AECF54C2A03BF73C71B9B50C6C144713A22CDE40D261C236";
            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);
            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String( hashBytes);
        }
    }
}
