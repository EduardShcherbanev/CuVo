using System;
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

        public VocabularyLogic(UserManager<ApplicationUser> userManager, IWordRepository wordRepository, ILearningRepository learningRepository) : base(userManager)
        {
            _wordRepository = wordRepository;
            _learningRepository = learningRepository;
        }

        public async Task<UserWord> AddWord(Word word)
        {
            if (string.IsNullOrEmpty(word.Spelling))
            {
                throw new EmptySpellingException();
            }

            Word currentWord = await _wordRepository.GetWord(word.Id) ?? (await _wordRepository.GetWord(word.Spelling) ?? await _wordRepository.AddWord(word));

            string userId = UserManager.GetUserId(ClaimsPrincipal.Current);

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
