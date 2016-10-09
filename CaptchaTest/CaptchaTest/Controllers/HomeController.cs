using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaptchaTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string empty)
        {
            // Code for validating the CAPTCHA  
            if (this.IsCaptchaValid("Captcha is not Valid"))
            {
                return RedirectToAction("ThankyouPage");
            }
            ViewBag.ErrMessage = "Error: captcha is not valid.";
            ViewBag.SetErrMsg = false;
            return View();
        }

        public ActionResult ThankYouPage()
        {
            return View();
        }
    }
}