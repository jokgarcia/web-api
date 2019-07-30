using System.Collections.Generic;
using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public interface IEmployeeService
    {
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        IList<Employee> GetEmployees();
        Employee SearchEmployee(int id);
        bool UpdateEmployee(Employee employee);
    }
}