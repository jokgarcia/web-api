using System.Collections.Generic;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);
        IList<Employee> GetEmployees();
        Employee SearchEmployee(int id);
        bool UpdateEmployee(Employee employee);
    }
}