using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AddMultiply
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b=5;
            int add;
            int mul;
            AddMultiplication(a, b,out add,out mul);
            Console.WriteLine(add);
            Console.WriteLine(mul);
            Console.ReadKey();
        }
        public static void AddMultiplication(int a, int b,out int add,out int mul) 
        {

            add = a + b;
            mul = a * b;
        
        }
    }
}
