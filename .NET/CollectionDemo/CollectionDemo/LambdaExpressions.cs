using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public delegate int DelegateAdd(int x, int y);
    public delegate bool DelegateTest(int x);
    public delegate string HelloDelegate1(string name);
    internal class LambdaExpressions
    {
        static void Main(string[] args)
        {
            //DelegateAdd delegateAdd = (x, y) => (x + y);
            //Console.WriteLine(delegateAdd(50, 90));




            //DelegateTest delegateTest = x => (x % 2 == 0);
            //Console.WriteLine(delegateTest(40));



            //Statement Delegate
            HelloDelegate1 helloDelegate1 = (name) =>
            {



                return "Hello" + name;



            };



            Console.WriteLine(helloDelegate1("Harry"));


        }
    }
    }
