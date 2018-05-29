using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuVo.DBRepository.Interfaces;
using CuVo.Models.Learning;
using CuVo.Models.Vocabulary;
using Microsoft.EntityFrameworkCore;

namespace CuVo.DBRepository.Repositories
{
    public class LearningRepository : BaseRepository, ILearningRepository
    {
        public LearningRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory)
        {
        }

        public async Task<UserWord> AddUserWord(UserWord userWord)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                await context.UserWords.AddAsync(userWord);
                await context.SaveChangesAsync();
            }

            return userWord;
        }

        public async Task<UserWord> GetUserWord(int wordId, string userId)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.UserWords.SingleOrDefaultAsync(uw => uw.WordId == wordId && uw.UserId == userId);
            }
        }

        public async Task<List<UserWord>> GetUserWords(string userId)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.UserWords
                    .Where(uw => uw.UserId == userId)
                    .Include(w => w.Word.Language)
                    .Include(w => w.Word.PartOfSpeech)
                    .Include(w => w.Word.Level)
                    .ToListAsync();
            }
        }
    }
}
