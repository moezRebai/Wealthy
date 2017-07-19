using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthy.Data.Infrastructure.Helpers
{

    /// <summary>
    /// Class that allow to dispose non managed objects. It implements the IDisposable interface. 
    /// Then any class will just want to inherit this very class.
    /// </summary>
    public class DisposableBase : IDisposable
    {
        private bool isDisposed;

        ~DisposableBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        //virtual method cause this method will make others classes
        //inherit this one, to dispose their own objects in the way the need to.
        protected virtual void DisposeCore()
        {
        }
    }
}
