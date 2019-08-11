using DataAccessLayer.Data;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EmployeeManagement.Core.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;
        private readonly ILogger<EmployeeRepository> _logger;


        public EmployeeRepository(EmployeeContext context, ILogger<EmployeeRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context");
            _context.Add(entity);
        }

        public bool Update<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context");
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context.");
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempting to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Employee[]> GetEmployees()
        {
            _logger.LogInformation($"Getting all Employees");
            IQueryable<Employee> query = _context.Employees;

            query = query.OrderBy(e => e.LastName);

            return await query.ToArrayAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            _logger.LogInformation($"Get Employee by Id");

            var query = _context.Employees.Where(e => e.Id == id).OrderBy(e => e.LastName);

            return await query.FirstOrDefaultAsync();
        }
    }
}
