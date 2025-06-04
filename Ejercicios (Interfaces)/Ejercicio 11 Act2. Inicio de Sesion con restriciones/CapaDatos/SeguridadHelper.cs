using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class SeguridadHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string hashInput = HashPassword(inputPassword);
            return hashInput == storedHash;
        }
    }
}
