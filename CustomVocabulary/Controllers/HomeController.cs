﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using CustomVocabulary.Models.Vocabulary;
using CuVo.Models.Learning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomVocabulary.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IVocabularyLogic _vocabularyLogic;

        public HomeController(IVocabularyLogic vocabularyLogic)
        {
            _vocabularyLogic = vocabularyLogic;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize]
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
