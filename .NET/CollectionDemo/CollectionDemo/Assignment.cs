using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Assignment
    {
        static void Main(string[] args)
        {
            List<Cart> shoppingCart=new List<Cart>();
            Console.WriteLine("Enter no of Products you want to add");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Cart Id");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product name");
                string s = Console.ReadLine();

                Cart e1 = new Cart { CardId = a, ProductName = s };


                shoppingCart.Add(e1);


                Console.WriteLine("Successfully Added items\n");
            }

            Console.WriteLine("Displaying All products we have!\n");
            foreach (Cart e in shoppingCart)
            {
                Console.WriteLine("Cart  Id: " + e.CardId);
                Console.WriteLine("Product  Name: " + e.ProductName);
            }

            Console.WriteLine("\nEnter the product name to be deleted\n");
            string w = Console.ReadLine();
            
            

            
            foreach(Cart r in shoppingCart)
            {
                
                if(r.ProductName == w)
                {
                    shoppingCart.Remove(r);
                    Console.WriteLine(" Successfully Removed\n");
                }
            }

            Console.WriteLine("Final list of Items left in cart\n");
            foreach (Cart g in shoppingCart)
            {
                Console.WriteLine("Cart  Id: " + g.CardId);
                Console.WriteLine("Product  Name: " + g.ProductName);
            }




        }
    }
}
