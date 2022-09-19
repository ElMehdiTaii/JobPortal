using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Entities.Models
{
    public class Apply : BaseModel
    {
        public int UserId { get; set; }
        public int OfferId { get; set; }

        public Users User { get; set; }
        public Offer Offer { get; set; }
    }
}
