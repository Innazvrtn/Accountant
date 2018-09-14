using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        #region InterfaceMethods

        IEnumerable<T> GetList();
        T Get(Guid id);
        void Create(T item);
        void Update(T item);
        void Delete(Guid id);

        #endregion
    }
}
