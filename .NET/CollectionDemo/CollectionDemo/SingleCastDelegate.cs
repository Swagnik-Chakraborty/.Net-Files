using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public delegate void SimpleDelegate(string name);
    internal class SingleCastDelegate
    {
        static void Main(string[] args)
        {
            SimpleDelegate ss = new SimpleDelegate(TestMethod);
            ss.Invoke("Swagnik");
        }
        public static void TestMethod(string name) 
        {
        
            Console.WriteLine("Hello={0}",name);

        }

    }
}
