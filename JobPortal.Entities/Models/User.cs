using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Entities.Models
{
    public class User : BaseModel
    {

        public User()
        {
            Apply = new HashSet<Apply>();
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public int Activity { get; set; }
        public bool IsActive { get; set; }
        public int IsDelete { get; set; }
        public ICollection<Apply> Apply { get; set; }

    }
}
