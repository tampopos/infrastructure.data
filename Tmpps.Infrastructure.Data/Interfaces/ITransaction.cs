using System;

namespace Tmpps.Infrastructure.Data.Interfaces
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}