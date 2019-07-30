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
        public bool AddEmployee(Employee employee)
        {
            _repository.AddEmployee(employee);
            return true;
        }
        public IList<Employee> GetEmployees()
        {
            return _repository.GetEmployees();
        }

        public Employee SearchEmployee(int id)
        {
            return _repository.SearchEmployee(id);
        }
        public bool UpdateEmployee(Employee employee)
        {
            return _repository.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(Employee employee)
        {
            return _repository.DeleteEmployee(employee);
        }
    }
}


