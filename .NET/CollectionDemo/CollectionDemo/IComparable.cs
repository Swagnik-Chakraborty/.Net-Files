using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Employee : IComparable
    {



        public int ID;
        public string EmployeeName;
        public int Salary;



        // Employee constructor
        public Employee(int id, string employeename, int sal)
        {
            this.ID = id;
            this.EmployeeName = employeename;
            this.Salary = sal;
        }



        public int CompareTo(object obj)
        {



            //            // Storing incoming object in temp variable of 
            //            // current class type
            Employee tempemployee = obj as Employee;



            return this.ID.CompareTo(tempemployee.ID);
        }

        internal class IComparable
    {
            static void Main(string[] args) 
            
            {
                Employee[] employees =
       {
                    new Employee(1, "Tom",2000),
            new Employee(5, "Dip",8000),
            new Employee(3, "Harry",1000),
            new Employee(2, "Jack",3000),
            new Employee(4, "Jill",4000)
                        };




                // Displaying the employee's array before sorting
                Console.WriteLine("Before sorting employees array");
                foreach (Employee emp in employees)
                {
                    Console.WriteLine("ID - {0} Employee Name - {1} Salary ={2}", emp.ID, emp.EmployeeName, emp.Salary);



                }



                Array.Sort(employees);





                // Printing the employee's array after sorting
                Console.WriteLine("After sorting employees array");
                foreach (Employee emp in employees)
                {
                    Console.WriteLine("ID - {0} Employee Name - {1} Salary ={2}", emp.ID, emp.EmployeeName, emp.Salary);
                }
            }


        }

    }
}
