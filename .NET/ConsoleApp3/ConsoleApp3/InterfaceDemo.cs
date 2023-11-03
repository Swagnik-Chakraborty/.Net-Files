using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public interface Ishape
    {
        float CalculateArea();
    }

    public interface IPrintable
    {
        void print();
    }

    public class Circle : Ishape, IPrintable
    {
        public float CalculateArea()
        {
            int r = 10;
            return (3.14f * r * r);
        }

        public void print()
        {
            Console.WriteLine("Print Method");
        }
    }
    internal class InterfaceDemo
    {

        static void Main(string[] args)
        {
            Circle circle=new Circle();
            Console.WriteLine(circle.CalculateArea());
            circle.print();

        }
    }
}
