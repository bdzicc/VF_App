using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationVF.Controllers
{
    public class MiscController : Controller
    {
        // GET: Misc
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["CurrentUser"] = null;
            Session.Abandon(); 
            return RedirectToAction("index", "Home");
        }

        [HttpPost]
        public ActionResult SendText(WebApplicationVF.Models.TextModel textModel)
        {
            string phoneNum1 = textModel.Phone1;
            string phoneNum2 = textModel.Phone2;
            string phoneNum3 = textModel.Phone3;
            string txtMsg = textModel.SMSMessage;

            using (var client = new HttpClient())
            {

                //HTTP POST text message to numbers
                //Get/Check response code and return response
           
            }

            return View();
        }

    }
}