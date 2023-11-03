using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class GenericMethodDemo
    {
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'C';
            d = 'D';



            //display values before swap:
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);



            //call swap
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);



            //display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);



            Console.ReadKey();
        }
        static void Swap<T>(ref T p1, ref T p2)
        {
            T temp;
            temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}
