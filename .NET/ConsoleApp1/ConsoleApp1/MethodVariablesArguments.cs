using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodVariablesArguments
    {
        static void Main(string[] args)
        {
            Method(100,200);
            Console.ReadKey();
        }
        public static void Method(params int[]arr) { 
        

            for (int a=0;a<arr.Length;a++)
            {
                Console.WriteLine(arr[a]);
            }
        
        }
    }
}
