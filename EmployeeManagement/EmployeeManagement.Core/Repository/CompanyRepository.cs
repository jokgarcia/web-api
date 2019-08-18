using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Repository
{
    public class CompanyRepository  

    {
        private readonly EmployeeContext _context;
        private readonly ILogger<CompanyRepository> _logger;
        public CompanyRepository(EmployeeContext context, ILogger<CompanyRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type  { entity.GetType()}  to the context");
            _context.Add(entity);
        }

        public bool Update<T>(T entity) where T : class
        {
            _logger.LogInformation($"Update an object of type {entity.GetType()}  to the context");
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;

        }

    }
}
