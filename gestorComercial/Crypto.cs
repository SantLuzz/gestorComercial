using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Academia
{
    internal class Crypto
    {
        public static string encode(string text)
        {
            MD5 crypto = MD5.Create();
            Byte[] input = Encoding.ASCII.GetBytes(text);
            Byte[] hash = crypto.ComputeHash(input);

            StringBuilder final = new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                final.Append((hash[i]).ToString("X2"));
            }

            return final.ToString();
        }
    }
}
