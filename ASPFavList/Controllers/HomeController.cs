using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPFavList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult AddToFavList(string Name)
        {
            if (Session["FavList"] == null)
            {
                Session.Add("FavList", new List<string>());
            }

            List<string> FavList = (List<string>)Session["FavList"];

            if (!FavList.Contains(Name))
            {
                FavList.Add(Name);

            }
            Session["FavList"] = FavList;
            ViewBag.FavList = FavList;
            return View("About");
        }
    }
}