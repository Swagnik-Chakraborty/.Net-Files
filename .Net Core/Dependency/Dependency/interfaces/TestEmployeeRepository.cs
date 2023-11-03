using Dependency.Models;

namespace Dependency.interfaces
{
    public class TestEmployeeRepository:IEmployeeRepository
    {
        public List<Employee> DataSource()
        {
            return new List<Employee>()
            {
                new Employee() { EmpId = 101, EmpName = "Swagnik", Designation = "Developer" },
                new Employee() { EmpId = 102, EmpName = "Swastik", Designation = "Tester" },
                 new Employee() { EmpId = 103, EmpName = "Swapnil", Designation = "Developer" },
                  new Employee() { EmpId = 104, EmpName = "Chandan", Designation = "Developer" },

            };
        }
        public Employee GetEmpById(int EmpId)
        {
            return DataSource().FirstOrDefault(e => e.EmpId == EmpId);
        }
        public List<Employee> GetAllEmployee()
        {
            return DataSource();
        }
    }
}
