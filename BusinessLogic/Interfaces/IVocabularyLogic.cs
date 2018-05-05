using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CuVo.Models.Learning;
using CuVo.Models.Vocabulary;

namespace BusinessLogic.Interfaces
{
    public interface IVocabularyLogic
    {
        Task<UserWord> AddWord(Word word, string userId);
    }
}
