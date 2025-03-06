using practise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//**Design a Role-Based Access System**
//Create a base class `User` with properties like `Username` and `Role`.
//Derive `Admin` and `Customer` classes that override a method `AccessControl()`,
//where `Admin` can access all features, but `Customer` has limited access.

namespace practise
{
    
    class User
    {
        protected string Username, Role;

        public User(string username,string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username}::{Role}\nAccent isn't defined");
        }
    }
    class Admin:User
    {
        public Admin(string Username) : base(Username, "Admin")
        {

        }
        public override void AccessControl()
        {
            Console.WriteLine($"{Username}[{Role}]: You have full access to the system.");
        }
    }

    class Customer : User
    {
        public Customer(string username) : base(username,"Customer")
        {
        }
        public override void AccessControl()
        {
            Console.WriteLine($"{Username}[{Role}]: You don't have access to the system.");
        }
    }
}
