using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wealthy.Data.Entities.Configuration;

namespace Wealthy.Data.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface that will allow us to use/inject our dbcontext.
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        WealthyEntities Init();
    }
}
