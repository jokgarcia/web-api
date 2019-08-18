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
    public class AccountabilityService : IAccountabilityService
    {

        private IAccountabilityRepository _repository;
        public AccountabilityService(IAccountabilityRepository repository)
        {
            _repository = repository;
        }
        public async Task<Accountability> AddAccountability(Accountability accountability)
        {
            var container = new Accountability();

            _repository.Add(accountability);
            if (await _repository.SaveChangesAsync())
            {
                return accountability;
            }

            return container;
        }

        public async Task<Accountability> UpdateAccountability(Accountability accountability)
        {
            var container = new Accountability();

            _repository.Update(accountability);
            if (await _repository.SaveChangesAsync() == true)
            {
                return accountability;
            }
            return container;
        }

        public async Task<Accountability[]> GetAccountabilities()
        {
            return await _repository.GetAccountabilities();
        }

        public async Task<Accountability> GetAccountabilityById(int id)
        {
            return await _repository.GetAccountabilityById(id);
        }

        public async Task<Accountability> DeleteAccountability(Accountability accountability)
        {
            var container = new Accountability();

            _repository.Delete(accountability);
            if (await _repository.SaveChangesAsync())
            {
                return accountability;
            }

            return container;
        }
    }
}


