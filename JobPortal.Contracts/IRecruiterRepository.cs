using JobPortal.Entities.DTOs.RecruiterDto;
using JobPortal.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Contracts
{
    public interface IRecruiterRepository : IRepositoryBase<Recruiter>
    {
        Task<Recruiter> Login(RecruiterForLoginDto recruiterForLogin);
        Recruiter Register(RecruiterForRegisterDto recruiterForRegister);
    }
}
