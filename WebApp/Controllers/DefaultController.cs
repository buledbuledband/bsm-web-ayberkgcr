using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [Route("Hakkımızda")]
     
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("Urunler")]
        public ActionResult Urunler()
        {
            return View();
        }
        [Route("Magaza")]
        public ActionResult Magaza()
        {
            return View();
        }
    }
}