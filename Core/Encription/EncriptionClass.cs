using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Core.Encription
{
    public abstract class EncriptionClass : IDisposable
    {
        #region Fields&Properties

        protected static readonly string PasswordHash = "P@@Sw0rd";
        protected static readonly string SaltKey = "S@LT&KEY";
        protected static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        protected abstract string Work(string text);

        protected object fileLocker = new object();

        #endregion

        #region DisposableItems

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }

        #endregion
    }
}
