using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switch
    {
       static void Main(string[] args)
        {
            string snack = null;
            Console.WriteLine("Enter Snacks Name");
            snack = Console.ReadLine();



            switch (snack)
            {
                case "Burger":
                    Console.WriteLine("Burger costs you Rs. 100");
                    break;



                case "Pizza":
                    Console.WriteLine("Pizza costs you Rs. 200");
                    break;



                case "Pani Puri":
                    Console.WriteLine("Pani Puri costs you Rs. 30");
                    break;



                default:
                    Console.WriteLine("We dont serve this");
                    break;
            }
                    Console.ReadKey();
            
        }
    }
}
