using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using CuVo.DBRepository.Interfaces;
using CuVo.Models.Learning;
using CuVo.Models.User;
using CuVo.Models.Vocabulary;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic
{
    public class VocabularyLogic : BaseLogic, IVocabularyLogic
    {
        private readonly IWordRepository _wordRepository;
        private readonly ILearningRepository _learningRepository;

        public VocabularyLogic(IWordRepository wordRepository, ILearningRepository learningRepository) : base()
        {
            _wordRepository = wordRepository;
            _learningRepository = learningRepository;
        }

        public async Task<UserWord> AddWord(Word word, string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new EmptyUserIdException();
            }

            if (string.IsNullOrEmpty(word.Spelling))
            {
                throw new EmptySpellingException();
            }

            Word currentWord = await _wordRepository.GetWord(word.Id) ?? (await _wordRepository.GetWord(word.Spelling) ?? await _wordRepository.AddWord(word));

            UserWord userWord = await _learningRepository.GetUserWord(currentWord.Id, userId) ??
                                await _learningRepository.AddUserWord(new UserWord
                                {
                                    WordId = currentWord.Id,
                                    UserId = userId
                                });

            return userWord;
        }
    }
}
