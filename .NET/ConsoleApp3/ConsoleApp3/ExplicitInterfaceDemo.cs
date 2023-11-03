using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IControl
    {
        void Paint();
    }
    public interface ISurface
    {
        void Paint();



    }



    public class DemoClass : IControl
    {
        public void Paint()
        {
            Console.WriteLine("Icontrol.Paint of  Demo Class");
        }
    }









    public class SampleClass : IControl, ISurface
    {
        void IControl.Paint()
        {
            Console.WriteLine("IControl.Paint");
        }




        void ISurface.Paint()
        {
            Console.WriteLine("ISurface.Paint");
        }
    }



    class ExplicitInterfaceDemo
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();




            //  sample.Paint(); // Compiler error.




            IControl control = sample;
            ISurface surface = sample;



            // The following lines all call the same method.




            control.Paint();  // Calls IControl.Paint on SampleClass.
            surface.Paint();  // Calls ISurface.Paint on SampleClass.



            //DemoClass dc = new DemoClass();
            //dc.Paint();








        }
    }
}
