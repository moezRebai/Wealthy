using System.Data.Entity;
using Wealthy.Model;

namespace Wealthy.Data.Entities.Configuration
{
    /// <summary>
    ///  This file represents the DbContext class that will be responsible to
    ///  access the database.
    /// </summary>
    /// 
    public class WealthyEntities : DbContext
    {
        public WealthyEntities() : base("WealthyEntities") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AccountConfiguration());
        }
    }
}
