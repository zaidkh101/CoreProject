using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreProjectRemasterd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreProjectRemasterd.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public AccountController(ApplicationDbContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            this.dbContext = dbContext;
            HostingEnvironment = hostingEnvironment;
        }

        public IHostingEnvironment HostingEnvironment { get; }

        public IActionResult Register()
        {

            ViewBag.RoleList = new SelectList(dbContext.Roles.ToList(), "RoleID", "RoleName");
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            var myFiles = HttpContext.Request.Form.Files;
            foreach (var img in myFiles)
            {
                if (img != null && img.Length > 0)
                {
                    var file = img;
                    var upload = Path.Combine(HostingEnvironment.WebRootPath, "img\\users");
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(upload, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            user.UserImage = "~/img/users/" + fileName;
                        }
                    }
                }
            }
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            ViewBag.RoleList = new SelectList(dbContext.Roles.ToList(), "RoleID", "RoleName");
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var checkUser = dbContext.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password);

            if (checkUser.Any())
            {

                HttpContext.Session.SetString("myName", user.UserName);
                HttpContext.Session.SetString("password", user.Password);
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            return View(user);
        }
        public IActionResult UserProfile()
        {
            return View();
        }
    }
}
