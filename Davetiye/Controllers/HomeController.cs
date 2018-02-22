using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Davetiye.Models;

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
        [HttpGet]
        public ViewResult DavetiyeFormu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult DavetiyeFormu(DavetiyeCevap formdanyollanan)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", formdanyollanan);
            } else
            {
                return View();
            }
            
        }
    }
}