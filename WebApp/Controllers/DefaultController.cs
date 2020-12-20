using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
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
            using (kahve2020Entities db = new kahve2020Entities())
            {
                var model = db.hakkimiza.Find(1);
                return View(model);
            }
               
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