using System.Threading.Tasks;
using EmployeeManagement.Core.Models;

namespace EmployeeManagement.Core.Services
{
    public interface ICompanyService
    {
        Task<Company> AddCompany(Company company);
        Task<Company[]> GetCompany();
        Task<Company> GetCompanyById(int id);
        Task<Company> UpdateCompany(Company company);
    }
}