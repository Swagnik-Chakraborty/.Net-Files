using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    
        class Student
        {
            public string firstName;
            public string lastName;
            public int id;



            public Student(string fn, string ln, int i)
            {
                firstName = fn;
                lastName = ln;
                id = i;
            }



            public override string ToString()
            {
                return id + " " + firstName + " " + lastName;
            }



            //Equals(), by default, returns true only if the two objects being compared reference the same object
            //instance in memory.For the Student class, we need to implement
            //Equals to return true if the two variables being compared contain the same state values
            //(firstName, lastName, and id).



            public override bool Equals(object obj)
            {
                Student temp;
                temp = (Student)obj;
                if (temp.firstName == this.firstName && temp.lastName == this.lastName && temp.id == this.id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }




            //public override int GetHashCode()
            //{
            //    return ToString().GetHashCode();
            //}



        }



        class ObjectDemo
        {
            static void Main(string[] args)
            {
                Student student1 = new Student("Ratan", "Tata", 101);



                // Student student2 = student1;
                Student student2 = new Student("Ratan", "Tata", 101);
                //   Console.WriteLine(student1.Equals(student2));
                Console.WriteLine(student2.Equals(student1));
                // Console.WriteLine(student1.ToString());
            }
        }
    }


