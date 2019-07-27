using System.Collections.Generic;
using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(Employee employee, Department dept);
        IList<Employee> GetEmployees();
        bool UpdateEmployee(Employee employee);
    }
}