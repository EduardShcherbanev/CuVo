using CuVo.DBRepository.Interfaces;
using DBRepository.Repositories;

namespace CuVo.DBRepository.Repositories
{
    public class WordRepository : BaseRepository, IWordRepository
    {
        public WordRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(
            connectionString, contextFactory)
        {
        }


    }
}
