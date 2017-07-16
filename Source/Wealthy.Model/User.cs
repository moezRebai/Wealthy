using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthy.Model
{
    /// <summary>
    /// Class that represents the global user.
    /// </summary>
    public class User
    {
        public Guid UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    
        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public virtual IList<Account> Accounts { get; set; }

        public User()
        {
            DateCreated = DateTime.Now;
        }
    }
}
