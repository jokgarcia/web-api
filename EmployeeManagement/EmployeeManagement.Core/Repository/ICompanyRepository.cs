using System.Threading.Tasks;
using EmployeeManagement.Core.Models;

namespace EmployeeManagement.Core.Repository
{
    public interface ICompanyRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<Company[]> GetCompanies();
        Task<Company> GetCompanyById(int id);
        Task<bool> SaveChangesAsync();
        bool Update<T>(T entity) where T : class;
    }
}