using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class AnonymousLambdaDemoAssignment
    {
        internal class Program
        {

            static void Main(string[] args)
            {
                Func<int, int, int> FuncAdd = delegate (int a, int b) { return a + b; };



                Console.WriteLine("FuncAdd:{0}", FuncAdd(100, 200));



                Action<int, int> ActionAdd = delegate (int a, int b) {



                    Console.WriteLine("ActionAdd:{0}", a + b);
                };
                ActionAdd(8, 2);



                Predicate<int> PredicateCheck = delegate (int age) { return age >= 18; };
                Console.WriteLine("PredicateCheck:{0}", PredicateCheck(40));



                Console.ReadKey();
            }
        }


    }
}
