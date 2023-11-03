using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    //Hiding a Member of a base class into the derived class
    public class Base
        {
        public void Display()
        {
            Console.WriteLine("Display of Base");
        }
        public string MyName { get; set; }
        }

    public  class Derived:Base
    {
        public new void MyName() { }
    }

    internal class Shadowing
    {

        static void Main(string[]args)
        {

            Base b=new Base();
            b.MyName = "Persistent";
            Derived d = new Derived();
            d.Display();
            d.MyName();
        }
    }
}
