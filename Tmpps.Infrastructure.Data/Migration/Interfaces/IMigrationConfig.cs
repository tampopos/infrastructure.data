namespace Tmpps.Infrastructure.Data.Migration.Interfaces
{
    public interface IMigrationConfig
    {
        string RootConnectionString { get; }
        string Path { get; }
        string Database { get; }
    }
}