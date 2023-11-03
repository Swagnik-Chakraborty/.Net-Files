namespace WebApplicationDay2.Models
{
    public class Employee
    {


        public string Name { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string Designation { get; set; }

        public int Salary { get; set; }

        public int Experience { get; set; }

        public string Married { get; set; }


        public string JobOpportunities { get; set; }



    }
    public enum Gender { Male, Female };
}

