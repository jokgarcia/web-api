using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IAccountabilityRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<Accountability> GetAccountabilityById(int id);
        Task<Accountability[]> GetAccountabilities();
        Task<bool> SaveChangesAsync();
        bool Update<T>(T entity) where T : class;
    }
}