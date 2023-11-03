using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwapNumbers
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            Console.WriteLine("Before Swapping, a:{0}, b: {1}",a,b);
            Swap(ref a, ref b);
            Console.WriteLine("After Swapping, a:{0},b: {1}", a, b);
            Console.ReadKey();
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp=a; 
            a=b;
            b=temp;
        }
    }
}
