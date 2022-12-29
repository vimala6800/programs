using lbmvc.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;


namespace lbmvc.Controllers
{
    public class loginController : Controller
    {
        private readonly ILogger<loginController> _logger;

        public loginController(ILogger<loginController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(User _login)
        {
            localbusinessmvcwebContext _localdbmvcContext = new localbusinessmvcwebContext();
            var status = _localdbmvcContext.Users.Where(m => m.Email == _login.Email && m.Password == _login.Password && m.RoleId == 1).FirstOrDefault();
            var status2 = _localdbmvcContext.Users.Where(m => m.Email == _login.Email && m.Password == _login.Password && m.RoleId == 2).FirstOrDefault();
            var status3 = _localdbmvcContext.Users.Where(m => _login.Email == "admin@gmail.com" && _login.Password == "admin").FirstOrDefault();

            if (status == null && status2 == null && status3 == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else if (status != null)
            {
                return RedirectToAction("SuccessPage", "Home");
            }
            else if (status2 != null)
            {
                return RedirectToAction("SuccessPage2", "Home");
            }
            else if (status3 != null)
            {
                return RedirectToAction("Admin", "Home");
            }





            return View(_login);
        }
        public IActionResult SuccessPage()
        {
            return View();
        }
        public IActionResult SuccessPage2()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}

