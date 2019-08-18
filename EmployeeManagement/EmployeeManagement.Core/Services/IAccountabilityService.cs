using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public interface IAccountabilityService
    {
        Task<Accountability> AddAccountability(Accountability accountability);
        Task<Accountability> GetAccountabilityById(int id);
        Task<Accountability[]> GetAccountabilities();
        Task<Accountability> UpdateAccountability(Accountability accountability);
    }
}