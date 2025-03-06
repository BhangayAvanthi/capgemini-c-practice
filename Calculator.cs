using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Method Overloading in a Calculator Class**

//Implement a `Calculator` class with overloaded methods `Add()`.
//It should accept two integers, three integers, and two double values separately. Demonstrate how method overloading works.


namespace practise
{
    class Calculator
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine($"2  int sum={num1 + num2}");
        }
        public void Add(int num1,int num2,int num3)
        {
            Console.WriteLine($"3 int sum={num1 + num2 + num3}");
        }
        public void Add(double num1,double num2)
        {
            Console.WriteLine($"2 double sum={num1 + num2}");
        }
    }
}