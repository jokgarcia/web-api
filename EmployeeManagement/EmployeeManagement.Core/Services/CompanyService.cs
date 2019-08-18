using EmployeeManagement.Core.Models;
using EmployeeManagement.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _repository;
        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }
        public async Task<Company> AddCompany(Company company)
        {
            var container = new Company();

            _repository.Add(company);
            if (await _repository.SaveChangesAsync())
            {
                return company;
            }

            return container;
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            if (_repository.Update(company) == true)
            {
                return null;
            }
            return company;
        }

        public async Task<Company[]> GetCompany()
        {
            return await _repository.GetCompanies();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            if (id > 0)
            {
                return await _repository.GetCompanyById(id);
            }
            return null;
        }
    }
}
