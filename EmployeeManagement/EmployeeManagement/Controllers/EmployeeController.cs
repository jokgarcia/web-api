using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace EmployeeManagement.Controllers
{

    public class EmployeeController : ApiController
    {
        private IEmployeeRepository employeeRepository = new EmployeeRepository();

        EmployeeController(IEmployeeRepository _employeeRepository)
        {
            this.employeeRepository = _employeeRepository;
        }

        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            IEnumerable<Employee> employees = this.employeeRepository.GetEmployees();
            return employees;
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            Employee employee = this.employeeRepository.GetEmployee(id);
            return employee;
        }

        // POST api/<controller>
        public void Post([FromBody]Employee employee)
        {
            this.employeeRepository.AddEmployee(employee);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Employee employee)
        {
            this.employeeRepository.EditEmployee(id, employee);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            this.employeeRepository.DeleteEmployee(id);
        }
    }
}