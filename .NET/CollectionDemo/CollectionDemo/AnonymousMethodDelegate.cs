using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public delegate void HelloWorld(string message);
    internal class AnonymousMethodDelegate
    {
        static void Main(string[] args)
        {
            HelloWorld hello = delegate (string message)

            {
                Console.WriteLine(message);
            };
            hello.Invoke("Swagnik");
        }
    }
}
