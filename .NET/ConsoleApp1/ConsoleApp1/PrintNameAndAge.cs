using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrintNameAndAge
    {
        static void Main(string[] args)
        {
            string name = null;
            int age = 0;

            Console.WriteLine("Enter Name");
            name=Console.ReadLine();

            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " " + age);


            Console.WriteLine("Name:{0} age:{1}", name, age);
            Console.ReadKey();
        }
    }
}
