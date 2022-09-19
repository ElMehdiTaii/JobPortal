using JobPortal.Contracts;
using JobPortal.Entities.Models;

namespace JobPortal.Repositories
{
    public class ApplyRepository : RepositoryBase<Apply>, IApplyRepository
    {
        public ApplyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
