using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
 
    class Employee//Base Class
    {
        protected int Age;
        protected int Experience;
        public virtual float Salary()
        {
            return 0;
        }


    }
    class SoftWareEngineer:Employee//Derived Classes
    {
        public SoftWareEngineer(int x,int y)
        {
            this.Experience = x;
            this.Age = y;
        }
        public override float Salary() {
            Console.WriteLine("Salary of Engineer");
            return Age * Experience;
        }
    }

    class Manager : Employee//Derived Classes
    {
        public Manager(int x, int y)
        {
            this.Age = x;
            this.Experience = y;
        }
        public override float Salary()
        {
            Console.WriteLine("Salary of Manager");
            return (Experience * Age);
        }
    }


    internal class MethodOverriding
    {
        static void Main(string[] args)
        {
          //  shape shape1;
            //shape1 = new Triangle(6, 7);
            //Console.WriteLine(shape1.Area());
            Employee[] emp = {new Manager(40,20),new SoftWareEngineer(20,10)};
            foreach(Employee val in emp)

            {
                Console.WriteLine(val.Salary());
            }

        }
    }
}
