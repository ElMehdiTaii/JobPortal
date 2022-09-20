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

        private ApplyRepository _applyRepository;

        private OfferRepository _offerRepository;

        private RecruiterDetailsRepository _recruiterDetailsRepository;

        private UsersRepository _usersRepository;

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

        public IApplyRepository ApplyRepository 
        {
            get
            {
                if (_applyRepository == null)
                {
                    _applyRepository = new ApplyRepository(_repoContext);
                }
                return _applyRepository;
            }
        }

        public IOfferRepository OfferRepository
        {
            get
            {
                if (_offerRepository == null)
                {
                    _offerRepository = new OfferRepository(_repoContext);
                }
                return _offerRepository;
            }
        }

        public IRecruiterDetailsRepository RecruiterDetailsRepository
        {
            get
            {
                if (_recruiterDetailsRepository == null)
                {
                    _recruiterDetailsRepository = new RecruiterDetailsRepository(_repoContext);
                }
                return _recruiterDetailsRepository;
            }
        }

        public IUsersRepository UsersRepository
        {
            get
            {
                if (_usersRepository == null)
                {
                    _usersRepository = new UsersRepository(_repoContext);
                }
                return _usersRepository;
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
