using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository
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
                Id = 1,
                Email = "asdasdas@gmail.com",
                FirstName = "John",
                LastName = "Doe"
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
