using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BoxingDemo
    {
        static void Main(string[] args)
        {
            int i = 0;//Value Type
            object o;//Reference Type
            o = i;//Boxing



            int j = 7;//Value Type

            j = (int)o;//Reference Type to value-Unboxing
            
        }
    }
}
