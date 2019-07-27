using System.Collections.Generic;
using DataAccessLayer.Models;
using EmployeeManagement.Core.Models;

namespace DataAccessLayer.Services
{
    public interface IEmployeeService
    {
        bool AddEmployee(Employee employee, Department dept);
        IList<Employee> GetEmployees();
    }
}