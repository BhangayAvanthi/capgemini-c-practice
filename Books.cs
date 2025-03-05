using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public  string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public Books()
        {
            Title = "unknown";
            Author = "unknown";
            ISBN = 0;
        }
        public Books(string title,string author)
        {
            Title = title;
            Author = author;
            ISBN = 0;
            Console.WriteLine($"Title::{title}");
            Console.WriteLine($"Author::{author}");
        }
        public Books(string title,string author,int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Console.WriteLine($"Title::{Title}");
            Console.WriteLine($"Author::{Author}");
            Console.WriteLine($"ISBN::{ISBN}");
        }

    }
}
