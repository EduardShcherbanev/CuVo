using System.Threading.Tasks;
using CuVo.DBRepository.Interfaces;
using CuVo.Models.Vocabulary;
using Microsoft.EntityFrameworkCore;

namespace CuVo.DBRepository.Repositories
{
    public class WordRepository : BaseRepository, IWordRepository
    {
        public WordRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(
            connectionString, contextFactory)
        {
        }

        public async Task<Word> AddWord(Word word)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                await context.Words.AddAsync(word);
                await context.SaveChangesAsync();
            }

            return word;
        }

        public async Task<Word> GetWord(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Words.SingleOrDefaultAsync(w => w.Id == id);
            }
        }

        public async Task<Word> GetWord(string spelling)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Words.SingleOrDefaultAsync(w => w.Spelling == spelling);
            }
        }
    }
}
