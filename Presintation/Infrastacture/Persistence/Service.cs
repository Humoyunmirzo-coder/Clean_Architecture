using Aplication.Handels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastacture.Persistence
{
    public class Service : Iservice
    {private IRepository repository;
        public Service()
        {
            repository = new Repository();
        }
        public IRepository CreateRepository(Grade grade)
        {
           repository.CreateRepository(grade);
        }

        public Task<bool> CreateRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Grade>> GetAll(Grade grade)
        {
            throw new NotImplementedException();
        }

        public Task<Grade> GetRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRepositoryAsync(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}
