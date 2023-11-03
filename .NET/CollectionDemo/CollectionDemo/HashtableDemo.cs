using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "Tina"); //Here key is Name and value is Tina
            hashtable.Add("Salary", 3500);
            hashtable.Add("Location", "Mumbai");
            hashtable.Add("EmailID", "Tina@a.com");







            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing using Foreach loop");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }




            hashtable.Remove("EmailID");



            Console.WriteLine("After Removing");
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " + hashtable[key]);
            }
        }
    }
}
