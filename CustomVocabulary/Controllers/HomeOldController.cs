using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CustomVocabulary.Models;
using CuVo.Models.User;
using CuVo.Models.Vocabulary;
using Microsoft.AspNetCore.Identity;

namespace CustomVocabulary.Controllers
{
    public class HomeOldController : Controller
    {
        private readonly IVocabularyLogic _vocabularyLogic;

        public HomeOldController(IVocabularyLogic vocabularyLogic, UserManager<ApplicationUser> userManager)
        {
            _vocabularyLogic = vocabularyLogic;
        }

        public async Task<IActionResult> Index()
        {
            //_vocabularyLogic.AddWord(new Word
            //{
            //    Description = "description",
            //    LanguageId = 1,
            //    PartOfSpeechId = 1,
            //    Spelling = "test"
            //}, User.FindFirst(ClaimTypes.NameIdentifier).Value);

            return View(await _vocabularyLogic.GetUserWords(User.FindFirst(ClaimTypes.NameIdentifier).Value));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
