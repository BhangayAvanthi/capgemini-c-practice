using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//**Constructor Overloading in a Library System**

//Implement a `Book` class with three different constructors:
//(1) Default constructor,
//(2) Constructor with `Title` and `Author`,
//(3) Constructor with `Title`, `Author`, and `ISBN`.
//Ensure each constructor initializes properties correctly.

namespace practise
{
    class Books
    {
        public Books()
        {
            Console.WriteLine("Books Default Constructor");
        }
        public Books(string Title,string Author)
        {
            Console.WriteLine($"Title::{Title}");
            Console.WriteLine($"Author::{Author}");
        }
        public Books(string Title,string Author,int ISBN)
        {
            Console.WriteLine($"Title::{Title}");
            Console.WriteLine($"Author::{Author}");
            Console.WriteLine($"ISBN::{ISBN}");
        }

    }
}
