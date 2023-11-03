using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public delegate void MathDelegate(int a, int b);
    internal class MultiCastDelegate
    {
        static void Main(string[] args)
        {
            MathDelegate math1 = new MathDelegate(Add);
            math1 += new MathDelegate(Multiply);

            math1.Invoke(10, 20);
        }

        public static void Add(int a, int b) 
        {
        int result=a+ b;
            Console.WriteLine(result);
        
        }
        public static void Multiply(int a, int b)
        
        {
        Console.WriteLine(a*b);
        }
    }
}
