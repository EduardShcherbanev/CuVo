using System;
using System.Collections.Generic;
using System.Text;
using CuVo.Models.User;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic
{
    public abstract class BaseLogic
    {
        protected UserManager<ApplicationUser> UserManager { get; }

        protected BaseLogic(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }
    }
}
