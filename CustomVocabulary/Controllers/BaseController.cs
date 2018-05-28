using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomVocabulary.Controllers
{
    public class BaseController : Controller
    {
        protected string CurrentUserId { get; set; }

        public BaseController()
        {
            CurrentUserId = "c524d2ef-6096-4756-b2b8-57560832f786";
        }
    }
}
