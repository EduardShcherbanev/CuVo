using CuVo.DBRepository.Data;

namespace CuVo.DBRepository.Interfaces
{
    public interface IRepositoryContextFactory
    {
        ApplicationDbContext CreateDbContext(string connectionString);
    }
}
