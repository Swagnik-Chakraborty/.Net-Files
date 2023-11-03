using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           OOPSdemo customer1 = new OOPSdemo();
            //  customer.SetCustomerDetails();
            //  customer.GetCustomerDetails();

            customer1[0] = 3;
            customer1[1] = "Swagnik";
            customer1[2] = "Chakraborty";

            //   OOPSdemo customer1 = new OOPSdemo(102, "Ratan Tata", "India");
            //customer1.GetCustomerDetails();



            //   customer.CustomerID = 10;
            Console.WriteLine("Customer Id :" + customer1[0]);
            Console.WriteLine("Customer Id :" + customer1[1]);
            Console.WriteLine("Customer Id :" + customer1[2]);
            Console.ReadKey();
        }
    }
}
