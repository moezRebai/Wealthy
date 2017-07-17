using System;
using System.Collections.Generic;
using System.Data.Entity;
using Wealthy.Model;

namespace Wealthy.Data.Entities.Configuration
{
    /// <summary>
    /// Class that seed the database when our application fire up for the first time
    /// </summary>
    public class WealthySeedData : DropCreateDatabaseIfModelChanges<WealthyEntities>
    {
        protected override void Seed(WealthyEntities context)
        {
            GetUsers().ForEach(u => context.Users.Add(u));
            GetAccounts().ForEach(a => context.Accounts.Add(a));

            context.Commit();
        }

        private static List<User> GetUsers() => new List<User>
            {
                new User {
                    FirstName = "Moez",
                    LastName = "Rebai",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            };

        private static List<Account> GetAccounts() => new List<Account>
            {
                new Account {
                    Name = "US1",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Account {
                   Name = "US2",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Account {
                   Name = "US3",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Account {
                   Name = "US4",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Account {
                   Name = "FX/OP",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Account {
                   Name = "EUR1",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            };
    }
}
