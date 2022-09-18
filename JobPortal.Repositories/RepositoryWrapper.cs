using JobPortal.Contracts;
using JobPortal.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;

        private RecruiterRepository _recruiterRepository;

        public IRecruiterRepository RecruiterRepository
        { 
            get
            {
                if(_recruiterRepository == null)
                {
                    _recruiterRepository = new RecruiterRepository(_repoContext);
                }
                return _recruiterRepository;
            }
        }

        public async Task<bool> SaveAsync()
        {
            if (await _repoContext.SaveChangesAsync() > 0)
                return true;
            return false;
        }
    }
}
