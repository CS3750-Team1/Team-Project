﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace Coding_Coalition_Project.Security
{
    public class PasswordEncryption
    {
        //IDataProtector _protector;        

        // the 'provider' parameter is provided by DI
        /**
        public PasswordEncryption(IDataProtectionProvider provider)
        {
            //_protector = provider.CreateProtector("Contoso.MyClass.v1");
        }
        
        public string EncryptInput(string lineIn)
        {
            Console.WriteLine($"Protect returned: {_protector.Protect(lineIn)}");
            return _protector.Protect(lineIn);

            /**
            Console.Write("Enter input: ");
            string input = Console.ReadLine();

            // protect the payload
            string protectedPayload = _protector.Protect(input);
            Console.WriteLine($"Protect returned: {protectedPayload}");

            // unprotect the payload
            string unprotectedPayload = _protector.Unprotect(protectedPayload);
            Console.WriteLine($"Unprotect returned: {unprotectedPayload}");
            
        }

        public string DecryptInput(string lineIn)
        {
            Console.WriteLine($"Protect returned: {_protector.Unprotect(lineIn)}");
            return _protector.Unprotect(lineIn);
        }
        */

        public static string EncryptString(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            Console.WriteLine(Convert.ToBase64String(array));
            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
