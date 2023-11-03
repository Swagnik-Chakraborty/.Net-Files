using System;
using System.Collections;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class queueDemo
    {
        static void Main(string[] args)
        {
            Queue people= new Queue();
            people.Enqueue("Swagnik1");
            people.Enqueue("Swagnik2");
            people.Enqueue("swagnik3");

            foreach (object person in people)
            {
                Console.WriteLine(person);
            }

            //  Console.WriteLine("Person Removed " + people.Dequeue());



            Console.WriteLine("After calling Peek " + people.Peek());
            //  Console.WriteLine("After Removing");

            foreach (object person in people)
            {
                Console.WriteLine(person);
            }



        }
    }
}
