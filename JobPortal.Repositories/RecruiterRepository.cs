using JobPortal.Contracts;
using JobPortal.Entities.Data;
using JobPortal.Entities.DTOs.RecruiterDto;
using JobPortal.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repositories
{
    public class RecruiterRepository : RepositoryBase<Recruiter>, IRecruiterRepository
    {
        public RecruiterRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public async Task<bool> RecruiterEmailExists(RecruiterForLoginDto recruiterForLogin)
        {
            var recruiter = await FindByCondition(x => x.Email == recruiterForLogin.Email)
                .FirstOrDefaultAsync();

            if (recruiter == null)
                return false;
            return true;
        }
        public async Task<Recruiter> Login(RecruiterForLoginDto recruiterForLogin)
        {
            var recruiter = await FindByCondition(x => x.Email == recruiterForLogin.Email)
                .FirstOrDefaultAsync();

            if (!PasswordHash.VerifyPasswordHash(recruiterForLogin.Password, recruiter.PasswordHash, recruiter.PasswordSalt))

                return null;

            return recruiter;
        }

        public Recruiter Register(RecruiterForRegisterDto recruiterForRegister)
        {
            byte[] passwordHash, passwordSalt;

            PasswordHash.CreatePasswordHash(recruiterForRegister.Password, out passwordHash, out passwordSalt);

            var recruiter = new Recruiter();

            recruiter.Email = recruiterForRegister.Email;

            recruiter.PasswordSalt = passwordSalt;

            recruiter.PasswordHash = passwordHash;

            Create(recruiter);

            return recruiter;
        }
    }
}
