using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DietCalc.Controllers
{
    public class HomeController : Controller
    {
        private DietCalcContext dbContext;
        public HomeController()
        {
            dbContext = new DietCalcContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            
            var accounts = dbContext.Accounts.ToList();
            return View(accounts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}