using JobPortal.Contracts;
using JobPortal.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repositories
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
        public UsersRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await FindAll().ToListAsync();
        }
    }
}
