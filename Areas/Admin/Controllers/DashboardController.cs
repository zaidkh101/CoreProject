using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProjectRemasterd.Models;
using CoreProjectRemasterd.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjectRemasterd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public DashboardController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            var userName = HttpContext.Session.GetString("myName");
            var password = HttpContext.Session.GetString("password");

            if (model.OldPassword == password)
            {
                var getUser = dbContext.Users.Where(x => x.UserName == userName && x.Password == password);
                foreach (var user in getUser)
                {
                    user.Password = model.NewPassword;
                    dbContext.Users.Update(user);
                }
            }

            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
