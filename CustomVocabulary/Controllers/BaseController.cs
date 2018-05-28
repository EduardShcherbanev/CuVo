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
        }
    }
}
