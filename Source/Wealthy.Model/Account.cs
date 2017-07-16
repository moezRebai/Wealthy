using System;

namespace Wealthy.Model
{
    /// <summary>
    /// Class that represents user account.
    /// </summary>
    public class Account
    {
        public Guid AccountID { get; set; }

        public string Name { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
        
    }
}