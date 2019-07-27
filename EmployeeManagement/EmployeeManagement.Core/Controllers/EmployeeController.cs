using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using EmployeeManagement.Core.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Core.Controllers
{
    [Route("api/[controller]")]
     
    public class EmployeeController : Controller 
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [Route("kunin")]
        [HttpGet]
        public async Task<IList<Employee>> Get()
        {
            return _service.GetEmployees();
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IList<Employee>> Get(int id)
        {
            return _service.GetEmployees();
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<bool> AddEmployee([FromBody] Employee employee, Department department)
        {
            _service.AddEmployee(employee, department);
            return true;
        }

        //public async Task<bool> Post()
        //{
        //    var employee = new Employee();
        //    var dept = new Department();
        //    employee.FirstName = "LeBron";
        //    employee.LastName = "James";
        //    employee.Email = "@email.com";
        //    employee.IsActive = true;
        //    dept.Name = "Acct";
        //    return await _service.AddEmployee(employee, dept);
        //}

    }
}
