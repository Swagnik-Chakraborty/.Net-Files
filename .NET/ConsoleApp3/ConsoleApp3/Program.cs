using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass= new MathClass();
            Console.WriteLine(mathClass.Add(4, 3));

        }
    }
}
