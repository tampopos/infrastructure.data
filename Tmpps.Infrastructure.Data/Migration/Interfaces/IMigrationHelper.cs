using System.Threading.Tasks;

namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationHelper
    {
        Task InitializeDatabaseAsync();
        Task InitializeAsync();
        Task MigrationAsync(string id, string path);
    }
}