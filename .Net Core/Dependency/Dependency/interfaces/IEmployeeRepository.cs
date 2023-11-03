using Dependency.Models;

namespace Dependency.interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmpById(int EmpId);
        List<Employee> GetAllEmployee();
    }
}
