using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    sealed class SecuritySystem
    {
        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Authenticating {username}...");
            Console.WriteLine("Access Granted!");
        }
    }
    //SecuritySystem class cannot be inherited becoz of sealed keyword
    //class AdvancedSecurity : SecuritySystem
    //{
    //    Console.WriteLine("hey..");
    //}
}
