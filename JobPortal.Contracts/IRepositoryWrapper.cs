using JobPortal.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Contracts
{
    public interface IRepositoryWrapper
    {
        IRecruiterRepository RecruiterRepository { get; }
        IApplyRepository ApplyRepository { get; }
        IOfferRepository OfferRepository { get; }
        IRecruiterDetailsRepository RecruiterDetailsRepository { get; }
        IUsersRepository UsersRepository { get; }
        Task<bool> SaveAsync();
    }
}
