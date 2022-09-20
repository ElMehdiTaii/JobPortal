using JobPortal.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Contracts
{
    public interface IUsersRepository : IRepositoryBase<Users>
    {
        Task<IEnumerable<Users>> GetAllUsers();
    }
}
