using CollectionDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class OutofStockException : Exception
    {
        public OutofStockException(string message) : base(message)
        {
        }
    }
    internal class CustomException
    {
        static void Main(string[] args)
        {
            int acceptorder;
            Console.WriteLine("Welcome to Shopping Site:\nHow many headphone you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptorder >= 1 && acceptorder <= 10)
                {
                    Console.WriteLine("Congratulations! You have bought {0} headphones", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutofStockException(" The number of items you want to buy is out of stock."));
                }
            }
            catch (OutofStockException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}