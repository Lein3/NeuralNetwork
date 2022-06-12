using System.Text;

namespace Constructor
{
    public static class HashingPassword
    {
        public static string Hashing_Function(string input)
        {
            using (var Hashing = System.Security.Cryptography.MD5.Create())
            {
                byte[] Hash = Hashing.ComputeHash(Encoding.UTF8.GetBytes(input));
                var Builder = new StringBuilder(Hash.Length * 2);
                for (int index = 0; index < Hash.Length; index++)
                {
                    Builder.Append($"{Hash[index]:X2}");
                }
                return $"{Builder}";
            }
        }
    }
}
