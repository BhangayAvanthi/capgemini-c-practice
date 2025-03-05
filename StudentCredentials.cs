using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

//**Data Hiding with Properties**

//Create a `Student` class where `Name` and `RollNo` are private fields.Use properties to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).


namespace practise
{
    class StudentCredentials
    {
        private string StudentName;
        private int RollNo;
        public string Name
        {
            get { return StudentName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("name can't be null/empty");
                //throw new ArgumentException("Invalid email address.");
                //throw new Exception("Name cannot be null/empty");
                else
                {
                    StudentName = value;
                }
            }
        }
        public int Number
        {
            get { return RollNo; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("roll numb cannnot be -ve");
                //throw new Exception("Roll number can't be -ve");
                else
                {
                    RollNo = value;
                }
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine("enter name::");
            Name = Console.ReadLine();
            Console.WriteLine("enter rollno::");
            Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("name::" + Name + "rolll::" + Number);
            Console.WriteLine($"name::{Name}\nrollno::{Number}");
        }

    }
}
