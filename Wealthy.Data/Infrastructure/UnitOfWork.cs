using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wealthy.Data.Entities.Configuration;
using Wealthy.Data.Infrastructure.Helpers;
using Wealthy.Data.Infrastructure.Interfaces;

namespace Wealthy.Data.Infrastructure
{
    /// <summary>
    /// The implementation of the IUnitOfwork interface.
    /// Here we will use some dependency injection by injecting our db context factory
    /// to ensure our unitofwork single instance. The dbFactory instantiation will be managed
    /// in another part by our IOC ( automapper :))
    /// </summary>
    public class UnitOfWork : DisposableBase, IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private WealthyEntities _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public WealthyEntities DbContext => _dbContext ?? (_dbContext = _dbFactory.Init());

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
