using System.Threading.Tasks;

namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationHelper
    {
        Task InitializeDatabaseAsync(string databaseName);
        Task InitializeAsync();
        Task MigrationAsync(string id, string path);
    }
}