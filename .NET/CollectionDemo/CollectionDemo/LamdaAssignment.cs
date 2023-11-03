using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    
        internal class LambdaAssignment
        {
            static void Main(string[] args)
            {
                Func<int, int, int> FuncAdd = (a, b) => (a + b);
                Console.WriteLine("FuncAdd:{0}", FuncAdd(1, 2));



                Predicate<int> PredicateCheck = (age) => (age >= 18);
                Console.WriteLine("PredicateCheck:{0}", PredicateCheck(15));



                Action<int, int> ActionAdd = (a, b) => Console.WriteLine("ActionAdd:{0}", a + b);
                ActionAdd(6, 2);



                Console.ReadKey();



            }
        }
}
