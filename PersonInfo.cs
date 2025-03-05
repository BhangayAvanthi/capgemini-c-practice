using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//**Using Virtual Methods in Inheritance**

//Create a `Person` base class with a `GetDetails()` method.
//Derive `Student` and `Teacher` classes that override `GetDetails()` to display their respective properties.
//Call `GetDetails()` using a base class reference.



namespace practise
{
    class PersonInfo
    {
        protected string Name;
        protected int Age;
        public PersonInfo(string name,int age)
        {
            Name = name;
            Age = age;
        }
       public void  GetDetails()
        {
            Console.WriteLine($"person info::\nName::{Name}\nAge::{Age}");
        }
    }

    class Teacher:PersonInfo
    {
        private string Subject;
        public Teacher(string name, int age,string subject) : base(name, age)
        {
            Subject = subject;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Teacher info::\nName::{Name}\nAge::{Age}\nsubject::{Subject}");
        }
    }

    class Student : PersonInfo
    {
        private int ID,Standard;

        public Student(string name, int age,int id,int standard) : base(name, age)
        {
            ID = id;
            Standard = standard;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Student info::\nName::{Name}\nID::{ID}\nAge::{Age}\nStandard::{Standard}");
        }
    }


}
