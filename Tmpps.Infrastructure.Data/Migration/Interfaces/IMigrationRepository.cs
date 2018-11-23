using System.Threading.Tasks;
using Tmpps.Infrastructure.Data.Interfaces;

namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationRepository<TMigrationHistory> : IRepository<TMigrationHistory> where TMigrationHistory : class, IMigrationHistory
    {
        Task<bool> ExistsAsync(string id);
        Task<TMigrationHistory> GetByIdAsync(string id);
        Task AddAsync(TMigrationHistory entity);
    }
}