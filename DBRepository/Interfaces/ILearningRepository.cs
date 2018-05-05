using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CuVo.Models.Learning;

namespace CuVo.DBRepository.Interfaces
{
    public interface ILearningRepository
    {
        Task<UserWord> AddUserWord(UserWord userWord);
        Task<UserWord> GetUserWord(int wordId, string userId);
        Task<List<UserWord>> GetUserWords(string userId);
    }
}
