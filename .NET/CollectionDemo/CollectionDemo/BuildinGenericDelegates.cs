using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class BuildinGenericDelegates
    {
        public delegate void HelloWorld(string message);
        static void Main(string[] args)
        {
           // Func<int, int, int> funcadd = new Func<int, int, int>(Add);
            //Console.WriteLine(funcadd(60,80));



            //Action<int, int> actiondelegate = new Action<int, int>(Add);
            //actiondelegate(20, 90);



            Predicate<int> predicatecheck = new Predicate<int>(CheckValue);
            Console.WriteLine(predicatecheck(500));



        }



        //public static int Add(int x,int y)
        //{ return x + y; }



        public static void Add(int x, int y)
        { Console.WriteLine(x + y); }



        public static bool CheckValue(int a)
        {
            if (a >= 100)
                return true;
            else
                return false;
        }
    }
}
