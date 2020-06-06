using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace Coding_Coalition_Project.Security
{
    public class PasswordEncryption
    {
        IDataProtector _protector;

        // the 'provider' parameter is provided by DI
        public PasswordEncryption(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Contoso.MyClass.v1");
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
            **/
        }
    }
}
