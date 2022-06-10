using System;
using System.Security.Cryptography;
using System.Text;

namespace Constructor
{
    public static class HashingPassword
    {
        public static string Hashing_Function(string input)
        {
            var hash = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
