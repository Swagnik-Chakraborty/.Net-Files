using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Swagnik");
            stack.Push("Swagnik1");
            stack.Push("Swagnik2");

            Console.WriteLine("Before Removing");

            foreach(object name in stack)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("After Removing");
         //  Console.WriteLine(stack.Pop());

            foreach (object name in stack)
            {
                Console.WriteLine(name);
            }
           Console.WriteLine(stack.Peek());
                

        }
    }
}
