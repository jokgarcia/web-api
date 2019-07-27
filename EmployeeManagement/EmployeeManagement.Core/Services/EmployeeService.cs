using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using EmployeeManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    //Business Logic
    public class EmployeeService : IEmployeeService
    {

        private IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public bool AddEmployee(Employee employee, Department dept)
        {
            if (employee != null)
            {
                _repository.AddEmployee(employee, dept);
                return true;
            }
            return false;
        }
        public IList<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }
    }
}


