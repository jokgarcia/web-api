using System;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Models;
using DataAccessLayer.Services;
using EmployeeManagement.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Core.Controllers
{
    [Route("api/[controller]")]
     
    public class AccountabilityController : ControllerBase 
    {
        private readonly IAccountabilityService _service;
        private readonly IMapper _mapper;

        public AccountabilityController(IAccountabilityService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [Route("kunin"),Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public async Task<ActionResult<Accountability[]>> GetAccountabilities()
        {
            try
            {
                var results = await _service.GetAccountabilities();
                return _mapper.Map<Accountability[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Accountability>> Get(int id)
        {
            try
            {
                var result = await _service.GetAccountabilityById(id);
                return _mapper.Map<Accountability>(result);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Accountability>> AddAccountability([FromBody] AccountabilityViewModel request)
        {

            try
            {
                var newAccountability = _mapper.Map<AccountabilityViewModel>(request);
                if (await _service.AddAccountability(newAccountability.accountability) != null)
                {
                    return Created($"Created", newAccountability);
                }
                
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult<Accountability>> UpdateAccountability([FromBody] AccountabilityViewModel request)
        {

            try
            {
                var newAccountability = _mapper.Map<AccountabilityViewModel>(request);
                if (await _service.UpdateAccountability(newAccountability.accountability) != null)
                {
                    return Created($"Created", newAccountability);
                }

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

            return BadRequest();
        }

        /// <summary>
        /// Update Employee.
        /// </summary>
        /// <param name="employee">Employee ViewModel.</param>
        /// <returns>True or False.</returns>
        //[HttpPut]
        //public async Task<ActionResult<Employee>> UpdateEmployee(int id, [FromBody] EmployeeViewModel viewModel)
        //{
        //    try
        //    {
        //        var previous = await _service.GetEmployeeById(id);
        //        if (previous == null) return NotFound($"Could not find employee {id}");
        //        _mapper.Map<Employee>(viewModel.employee);


        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        /// <summary>
        /// Delete Employee.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        //[HttpDelete]
        //public async Task<bool> DeleteEmployee(Employee employee)
        //{
        //    return _service.DeleteEmployee(employee);
        //}

    }
}
