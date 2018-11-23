namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationConfig
    {
        string Database { get; }
        string AdminConnectionString { get; }
    }
}