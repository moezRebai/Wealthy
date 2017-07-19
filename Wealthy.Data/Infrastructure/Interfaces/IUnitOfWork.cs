using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthy.Data.Infrastructure.Interfaces
{
    /// <summary>
    /// This interface will represent the only way the communicate and synchronize date 
    /// with Database, it's an implementation of UnitOfWork design pattern.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Method that will allow to send a commit command to the database.
        /// </summary>
        void Commit();
    }
}
