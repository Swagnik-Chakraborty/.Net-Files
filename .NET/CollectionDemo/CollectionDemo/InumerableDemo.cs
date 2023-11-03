using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
    }
    //ArrayList
    class School : IEnumerable
    {
        List<Student> students = new List<Student>();



        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Add(Student s)
        {
            students.Add(s);
        }



    }






    class IEnumerabledemo
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Id = 1;
            std1.Name = "Tom";
            std1.Standard = 10;



            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "Dip";
            std2.Standard = 11;




            Student std3 = new Student();
            std3.Id = 3;
            std3.Name = "Harry";
            std3.Standard = 12;




            //   ArrayList students = new ArrayList();
            School students = new School();



            students.Add(std1);
            students.Add(std2);
            students.Add(std3);



            foreach (Student s in students)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Standard);
            }
        }
    }
}
