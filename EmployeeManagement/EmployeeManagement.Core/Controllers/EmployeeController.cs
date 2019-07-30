using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using EmployeeManagement.Core.Models;
using EmployeeManagement.Core.ViewModels;
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
        public async Task<bool> AddEmployee([FromBody] EmployeeViewModel request)
        {
            
            _service.AddEmployee(request.employee);
            return true;
        }

        [HttpGet]
        public async Task<IList<Employee>> GetEmployees()
        {
            return _service.GetEmployees();
        }

        [HttpPut]
        public async Task<bool> UpdateEmployee(EmployeeViewModel employee)
        {
            return _service.UpdateEmployee(employee.employee);
        }

        [HttpDelete]
        public async Task<bool> DeleteEmployee(Employee employee)
        {
            return _service.DeleteEmployee(employee);
        }
        
    }
}
