using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using EmployeeManagement.Core.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var container = new Employee();

            _repository.Add(employee);
            if (await _repository.SaveChangesAsync())
            {
                return employee;
            }

            return container;
        }
        public async Task<Employee[]> GetEmployees()
        {
            return await _repository.GetEmployees();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _repository.GetEmployeeById(id);
        }
    }
}


