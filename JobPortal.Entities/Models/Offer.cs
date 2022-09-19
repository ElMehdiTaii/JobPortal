namespace JobPortal.Entities.Models
{
    public class Offer : BaseModel
    {
        public Offer()
        {
            Apply = new HashSet<Apply>();
        }
        public int RecruiterId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Country { get; set; }
        public int City { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDelete { get; set; }
        public Recruiter Recruiter { get; set; }
        public ICollection<Apply> Apply { get; set; }
    }
}
