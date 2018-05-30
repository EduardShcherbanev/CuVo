using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using CustomVocabulary.Models.Vocabulary;
using CuVo.Models.Learning;
using Microsoft.AspNetCore.Mvc;

namespace CustomVocabulary.Controllers
{
    public class VocabularyController : BaseController
    {
        private readonly IVocabularyLogic _vocabularyLogic;

        public VocabularyController(IVocabularyLogic vocabularyLogic)
        {
            _vocabularyLogic = vocabularyLogic;
        }

        [HttpGet]
        public async Task<List<UserWordViewModel>> GetVocabulary()
        {
            List<UserWord> userWords = await _vocabularyLogic.GetUserWords(CurrentUserId);

            List<UserWordViewModel> result = userWords.Select(uw => new UserWordViewModel
            {
                UserWordId = uw.Id,
                Spelling = uw.Word.Spelling,
                Description = uw.Word.Description,
                Language = uw.Word.Language.Name,
                PartOfSpeech = uw.Word.PartOfSpeech.Name,
                Level = uw.Word.Level.Name
            }).ToList();

            return result;
        }
    }
}