using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace EmployeeManagement.Controllers
{

    public class EmployeeController : ApiController
    {
        private IService service = new Service();

        EmployeeController(IService _service)
        {
            this.service = _service;
        }

        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            IEnumerable<Employee> employees = this.service.GetEmployees();
            return employees;
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            Employee employee = this.service.GetEmployee(id);
            return employee;
        }

        // POST api/<controller>
        public void Post([FromBody]Employee employee)
        {
            this.service.AddEmployee(employee);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Employee employee)
        {
            this.service.EditEmployee(id, employee);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            this.service.DeleteEmployee(id);
        }
    }
}