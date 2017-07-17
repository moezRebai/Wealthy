using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wealthy.Model;

namespace Wealthy.Data.Entities.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            Property(u => u.UserID).IsRequired().HasColumnOrder(0);
            Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            Property(u => u.LastName).IsRequired().HasMaxLength(50);
            Property(u => u.DateCreated).IsRequired();
            Property(u => u.DateUpdated).IsRequired();
        }
    }
}
