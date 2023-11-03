using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MethodOverload
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Add(69, 7));
            Console.WriteLine(Add("Swagnik", "Chakraborty"));
           
        }
        public static string Add(string a,string b) { 
        return a+ b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }
            
        }
}
