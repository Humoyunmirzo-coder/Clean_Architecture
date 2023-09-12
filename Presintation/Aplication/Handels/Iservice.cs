using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handels
{
    public interface Iservice
    {
        IRepository CreateRepository(Grade grade);
        Task<bool> CreateRepositoryAsync(Grade grade);
        Task<bool> DeleteRepositoryAsync(Grade grade);
        Task<bool> UpdateRepositoryAsync(Grade grade);
        Task<IEnumerable<Grade>> GetAll(Grade grade);
        Task<Grade> GetRepositoryAsync(Grade grade);
    }
}
