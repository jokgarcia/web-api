using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployee(Employee employee, Department dept);
    }
}