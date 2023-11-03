using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public abstract class Sample
    {
        //Non-abstract method
        public int Add(int x,int y)
        {
            return x + y;
        }

        //Abstract method
        public abstract int Multiply(int x, int y);
        
            

        
    }

    public class derived:Sample
    {
        public override int Multiply(int x,int y)
        {
            return x * y;
        }
    }
    internal class AbstractDemo
    {
        static void Main(string[]args)
        {
            derived d = new derived();
            Console.WriteLine(d.Add(2, 5));
            Console.WriteLine(d.Multiply(7, 9));
        }
    }
}
