using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    class EmployeeRepository
    {
        public bool AddEmployee()
        {

            return true;
        }
        public bool AddEmployee(Employee employee)
        {
            return true;
        }
        public IList<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            var employee = new Employee()
            {

            };


            return employees;
        }
        public bool UpdateEmployee()
        {

            return true;
        }
        public bool DeleteEmployee()
        {

            return true;
        }
    }
}
