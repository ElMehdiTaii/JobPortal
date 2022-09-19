using Microsoft.EntityFrameworkCore;

namespace JobPortal.Entities.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        public DbSet<Apply> Apply { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<RecruiterDetails> RecruiterDetails { get; set; }
        public DbSet<Users> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apply>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Apply)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Apply__UserId__412EB0B6");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Apply)
                    .HasForeignKey(d => d.OfferId)
                    .HasConstraintName("FK__Apply__OfferId__403A8C7D");
            });

            modelBuilder.Entity<RecruiterDetails>(entity =>
            {
                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.RecruiterDetails)
                    .HasForeignKey(d => d.RecruiterId)
                    .HasConstraintName("FK__Recruiter__Recru__3A81B327");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.RecruiterId)
                    .HasConstraintName("FK__Offer__Recruiter__3D5E1FD2");
            });
        }
    }
}
