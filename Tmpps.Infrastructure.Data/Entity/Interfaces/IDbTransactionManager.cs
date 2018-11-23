using System.Data;
using System.Threading.Tasks;
using Tmpps.Infrastructure.Data.Interfaces;

namespace Tmpps.Infrastructure.Data.Entity.Interfaces
{
    public interface IDbTransactionManager
    {
        Task<ITransaction> BeginTransactionAsync();
    }
}