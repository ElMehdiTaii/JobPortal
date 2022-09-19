using JobPortal.Contracts;
using JobPortal.Entities.Models;

namespace JobPortal.Repositories
{
    public class RecruiterDetailsRepository : RepositoryBase<RecruiterDetails>, IRecruiterDetailsRepository
    {
        public RecruiterDetailsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
