using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ListGenericDemo
    {
        static void Main(string[]args)
        {
            List<string> list = new List<string>(); 
            list.Add("one");
            list.Add("two");
            list.Add("three");

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            list.Remove("one");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
