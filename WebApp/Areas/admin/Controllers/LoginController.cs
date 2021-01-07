using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using System.Web.Security;

namespace WebApp.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Alogin(kullanicilar kullaniciformu)
        {
            using(kahve2020Entities db=new kahve2020Entities())
            {
                var kullaniciVarmi = db.kullanicilar.FirstOrDefault(x=>x.kad==kullaniciformu.kad && x.sifre==kullaniciformu.sifre);

                if (kullaniciVarmi !=null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciVarmi.kad, false);
                    return RedirectToAction("/index", "urunler");
                }

                ViewBag.Hata="Kullanıcı adı veya şifre hatalı!!";
                return View("index");
            }

            
        }
    }
}