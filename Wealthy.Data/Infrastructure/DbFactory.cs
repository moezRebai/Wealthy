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
    /// Factory class that will be responsible for managing dbcontext instances.
    /// </summary>
    public class DbFactory : DisposableBase, IDbFactory
    {
        private WealthyEntities _dbContext;

        public WealthyEntities Init() => _dbContext ?? (_dbContext = new WealthyEntities());

        protected override void DisposeCore()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
