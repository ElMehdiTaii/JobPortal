using Microsoft.EntityFrameworkCore;

namespace JobPortal.Entities.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext() : base()
        {

        }
        public DbSet<Apply> Apply { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<RecruiterDetails> RecruiterDetails { get; set; }
        public DbSet<User> User { get; set; }
    }
}
