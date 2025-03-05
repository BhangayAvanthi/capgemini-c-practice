using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//**Abstraction with Abstract Classes**

//Design an abstract class `Shape` with an abstract method `CalculateArea()`.
//Create derived classes `Circle` and `Rectangle` that implement this method.
//Demonstrate abstraction by instantiating these classes.

namespace practise;

abstract class Shape
{
    public abstract void Area();
}

class Circle : Shape
{
    int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }
    public override void Area()
    {
        Console.WriteLine("Circle Area::"+(Math.PI*
            radius* radius));
    }
}

class Rectangle : Shape
{
    private int length, breadth;

    public Rectangle(int length, int breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public override void Area()
    {
        Console.WriteLine("Rectangle Area::" +(length*breadth));
    }
}
