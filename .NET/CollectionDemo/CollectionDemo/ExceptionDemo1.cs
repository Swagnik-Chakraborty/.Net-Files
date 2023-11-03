using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ExceptionDemo1
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int[] num = { 1, 2, 3, 4, 5 };
            try
            {
                int c = a / 0;
                Console.WriteLine(c);
               // num[8] = 100;
            }






            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("You cannot divide by zero");
            }
            catch (IndexOutOfRangeException e)
            {



                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }







            finally
            {
                Console.WriteLine("Finally Executed");
            }

        }
    }
}
