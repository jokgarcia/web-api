using System.Collections.Generic;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository
    {
        bool AddEmployee();
        bool AddEmployee(Employee employee);
        bool DeleteEmployee();
        IList<Employee> GetEmployees();
        bool UpdateEmployee();
    }
}