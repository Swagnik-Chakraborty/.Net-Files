using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ListDemo// difined own class named employee.cs
    {
        static void Main(string[]args)
        {
            List<employee> employees = new List<employee>();



            employee e1 = new employee { empId = 1, empName = "Swagnik1" }; // Object intializer
            employee e2 = new employee { empId = 2, empName = "Swagnik2" };




            employees.Add(e1);
            employees.Add(e2);



            foreach (employee employee in employees)
            {
                Console.WriteLine("Employee  Id: " + employee.empId);
                Console.WriteLine("Employee  Name: " + employee.empName);
            }
        }
    }
}
