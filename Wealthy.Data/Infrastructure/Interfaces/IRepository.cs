using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthy.Data.Infrastructure.Interfaces
{
    /// <summary>
    ///  A generic IRepository interface where we will declare the default operations that our repositories will support.
    ///  We added the most used methods, but we can extend those operations as we wish.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetById(Guid id);

        IEnumerable<T> GetAll();
    }
}
