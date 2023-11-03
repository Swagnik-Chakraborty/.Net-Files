using Dependency.Models;

namespace Dependency.interfaces
{
    public class TestStudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { StudentId = 101, Name = "James", Branch = "CSE" },
                new Student() { StudentId = 102, Name = "Smith", Branch = "ETC" },
                new Student() { StudentId = 103, Name = "David", Branch = "CSE" },
                new Student() { StudentId = 104, Name = "Sara", Branch = "CSE" },

            };
        }
        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == StudentId);
        }
        public List<Student> GetAllStudent()
        {
            return DataSource();
        }
    }
}
