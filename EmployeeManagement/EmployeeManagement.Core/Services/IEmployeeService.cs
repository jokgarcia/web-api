using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> GetEmployeeById(int id);
        Task<Employee[]> GetEmployees();
    }
}