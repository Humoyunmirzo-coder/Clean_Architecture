using Domain.Models;

namespace Aplication.Handels
{
    public interface IRepository
    {
         public void  CreateRepository(Grade grade  );
        Task < bool > CreateRepositoryAsync( Grade grade );
        Task< bool > DeleteRepositoryAsync( Grade grade);
        Task<bool> UpdateRepositoryAsync(Grade  grade);
        Task< IEnumerable<Grade > > GetAll(Grade  grade);
        Task <Grade > GetRepositoryAsync(Grade  grade);

    }
}