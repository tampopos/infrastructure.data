using System.Threading.Tasks;

namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationUseCase
    {
        Task<int> ExecuteAsync();
    }
}