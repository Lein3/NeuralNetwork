using System.Text;

namespace Constructor
{
    public static class HashingPassword
    {
        public static string Hashing_Function(string input)
        {
            using (var hashing = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = hashing.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder(hash.Length * 2);
                for (int index = 0; index < hash.Length; index++)
                {
                    builder.Append($"{hash[index]:X2}");
                }
                return $"{builder}";
            }
        }
    }
}
