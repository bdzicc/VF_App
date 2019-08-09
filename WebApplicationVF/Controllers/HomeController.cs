using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationVF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Verify(WebApplicationVF.Models.LoginModel loginModel)
        {
            string user = loginModel.UserName;
            string pass = loginModel.Password;
            string reverseUser = "";
            bool success = false;

            if (user != null && pass != null && user.Trim() != "" && pass.Trim() != "") // verify that the username and password fields have values
            {
                char[] userChars = user.ToCharArray();
                for (int i = userChars.Length - 1; i >= 0; i--)  //loop thorugh array backwards to arrange string in reverse
                {
                    reverseUser += userChars[i];
                }

                if (reverseUser == pass)
                {
                    success = true;
                }
            }

            if (success)
            {
                Session["CurrentUser"] = user;
                return RedirectToAction("Message", "Misc");
            }
            else
            {
                return View("Index", loginModel);
            }

        }
    }
}