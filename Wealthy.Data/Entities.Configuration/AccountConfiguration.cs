using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wealthy.Model;

namespace Wealthy.Data.Entities.Configuration
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            ToTable("Account");
            Property(a => a.AccountID).IsRequired().HasColumnOrder(0);
            Property(a => a.Name).IsRequired().HasMaxLength(50);
            Property(a => a.DateCreated).IsRequired();
            Property(a => a.DateUpdated).IsRequired();
        }
    }
}
