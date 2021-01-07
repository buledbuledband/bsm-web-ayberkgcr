using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models; //güncelleme işlemi için

namespace WebApp.Areas.admin.Controllers
{
    [Authorize]
    public class HakkimizdaController : Controller
    {
        // GET: admin/Hakkimizda
        public ActionResult Index()
        {
            using(kahve2020Entities db=kahve2020Entities()) //veritabanımızı bağlıyoruz
            {


                var model = db.hakkimizda.First(); //modelimizi view'e yollayacağız
                return View();

            }

            
        }
    }
}