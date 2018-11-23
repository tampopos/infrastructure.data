namespace Tmpps.Infrastructure.Data.Interfaces
{
    public interface IDbQueryCache
    {
        string GetSqlById(string sqlId);
    }
}