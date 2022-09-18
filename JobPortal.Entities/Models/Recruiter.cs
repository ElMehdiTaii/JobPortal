namespace JobPortal.Entities.Models
{
    public class Recruiter : BaseModel
    {
        public Recruiter()
        {
            RecruiterDetails = new HashSet<RecruiterDetails>();

            Offer = new HashSet<Offer>();
        }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<RecruiterDetails> RecruiterDetails { get; set; }
        public ICollection<Offer> Offer { get; set; }
    }
}
