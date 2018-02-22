using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Davetiye.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.karsilama = saat < 12 ? "Günaydın" : "Tünaydın";
            return View();
        }
    }
}