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

            using (kahve2020Entities db= new kahve2020Entities())
            {
                var model = db.urunler.Where(x=>x.aktif==true).OrderBy(x=>x.sira).ToList();
                     return View(model);
            }
           
        }
        [Route("urun/{id}")]
        public ActionResult UrunDetay(int id)
        {
            using (kahve2020Entities db= new kahve2020Entities())
            {
                var model = db.urunler.Where(x => x.aktif == true && x.id == id).FirstOrDefault();
                if (model==null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }
        }


        [Route("Magaza")]
        public ActionResult Magaza()
        {
            return View();
        }
    }
}