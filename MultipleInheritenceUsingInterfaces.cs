using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**Multiple Inheritance Using Interfaces**
//Define two interfaces `IPrintable` (for printing details) and `ISerializable` (for saving to a file).
//Implement both in a `Report` class and demonstrate multiple interface implementation.


namespace practise
{
    interface IPrintable
    {
        void Print();
    }
    interface ISerializable
    {
        void Save(string filename);
    }
    class Report:IPrintable,ISerializable
    {
        string Title, Content;

        public Report(string title,string content)
        {
            Title = title;
            Content = content;
        }
        public void Print()
        {
            Console.WriteLine($"Report Info::\nTitle={Title}\nContent={Content}");
        }
        public void Save(string filename)
        {
            File.WriteAllText(filename, Content);
            Console.WriteLine($"Report is saved as {filename}");
        }
    }
}
