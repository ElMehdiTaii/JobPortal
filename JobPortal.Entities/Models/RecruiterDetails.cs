using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Entities.Models
{
    public class RecruiterDetails : BaseModel
    {
        public int RecruiterId { get; set; }
        public string Logo { get; set; } = string.Empty;
        public string Background { get; set; } = string.Empty;
        public Recruiter Recruiter { get; set; }
    }
}
