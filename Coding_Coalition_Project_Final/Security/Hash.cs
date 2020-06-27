using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Coding_Coalition_Project.Security
{
    public class Hash
    {
        public static string Create(string value)
        {
            byte[] salt = new byte[128 / 8];

            var hashedBytes = KeyDerivation.Pbkdf2(
                             password: value,
                             salt: salt,
                             prf: KeyDerivationPrf.HMACSHA512,
                             iterationCount: 10000,
                             numBytesRequested: 256 / 8);
            
            Console.WriteLine($"Hash returned: " + Convert.ToBase64String(hashedBytes));

            return Convert.ToBase64String(hashedBytes);
        }
    }
}
