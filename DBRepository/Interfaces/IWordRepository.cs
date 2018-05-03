using System.Threading.Tasks;
using CuVo.Models.Vocabulary;

namespace CuVo.DBRepository.Interfaces
{
    public interface IWordRepository
    {
        Task<Word> AddWord(Word word);
        Task<Word> GetWord(int id);
        Task<Word> GetWord(string spelling);
    }
}
