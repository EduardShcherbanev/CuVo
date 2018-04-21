using CuVo.DBRepository.Data;
using CuVo.DBRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CuVo.DBRepository.Factories
{
    public class RepositoryContextFactory : IRepositoryContextFactory
    {
        public ApplicationDbContext CreateDbContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
