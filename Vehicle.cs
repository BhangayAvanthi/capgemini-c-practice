using practise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//**Method Overriding for a Vehicle System**

//Create a base class `Vehicle` with a method `Start()`.
//Override it in `Car` and `Bike` classes to provide specific implementations.
//Use the `override` keyword and demonstrate polymorphism.

namespace practise
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("starting");
        }
    }
    class car
    {
        public void Start()
        {
            Console.WriteLine("car started");
        }
    }
    class bike
    {
        public void Start()
        {
            Console.WriteLine("bike started");
        }
    }
}


