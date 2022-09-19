using JobPortal.Contracts;
using JobPortal.Entities.Models;

namespace JobPortal.Repositories
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
        public UsersRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
