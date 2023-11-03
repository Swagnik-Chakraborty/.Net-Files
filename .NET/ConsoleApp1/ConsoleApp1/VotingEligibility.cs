using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VotingEligibility
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age >= 18)
                Console.WriteLine("Eligible to Vote");
            else
                Console.WriteLine("Not Eligible");

            Console.ReadKey();
        }
    }
}
