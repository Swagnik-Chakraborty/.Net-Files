using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList cities= new ArrayList();
            cities.Add("Pune");
            cities.Add("Kolkata");
            cities.Add("Raiganj");

            Console.WriteLine("Before Deleting");
            foreach(string s in cities)
            {
                Console.WriteLine(s);
            }
            cities.Remove("Pune");
            Console.WriteLine("After Deleting");
            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }
            //cities.AddRange(cities);


        }

    }
}
