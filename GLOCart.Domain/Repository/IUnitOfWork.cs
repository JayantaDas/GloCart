using System;

namespace GLOCart.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
     //   Database Db { get; }
    }
}
