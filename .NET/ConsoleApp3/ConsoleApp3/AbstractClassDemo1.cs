using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public abstract class Employee1
    {
        int EmpId;
        string Ename;
        int Salary;
        int des;
        public void AcceptEmpDet(int id,string name,int sal,int de)
        {
            //Console.WriteLine("Hello1");
            EmpId = id;
            Ename = name;
            Salary= sal;
             des= de;
        }
        public void DispEmpDet()
        {
            Console.WriteLine("EmpId={0},EmpName={1},Salary={2},des={3}",EmpId,Ename,Salary,des);
        }
        public abstract int Cal_Sal();
        

        
    }
    public class FullTime : Employee1
    {
        int bs = 1000;
        int hra = 800;
        public override int Cal_Sal()
        {
            return bs + hra;
        }
    }
    public class Contract : Employee1
    {
        int hra = 100;
        int bonus = 10000;
        public override int Cal_Sal()
        {
            return hra + bonus;
        }
    }
    internal class AbstractClassDemo1
    {

        static void Main(string[] args)
        {
            Contract c=new Contract();
            c.AcceptEmpDet(1, "Swagnik", 30000, 2);
           
            c.DispEmpDet();
            Console.WriteLine(c.Cal_Sal());
            
        }
    }
}
