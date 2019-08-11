using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IEmployeeRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<Employee> GetEmployeeById(int id);
        Task<Employee[]> GetEmployees();
        Task<bool> SaveChangesAsync();
        bool Update<T>(T entity) where T : class;
    }
}