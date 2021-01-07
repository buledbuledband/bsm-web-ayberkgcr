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

        



        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Alogin(kullanicilar kullaniciformu, string ReturnUrl)
        {

            if (!ModelState.IsValid)
            {
                return View("index", kullaniciformu);
            }

            string sifre1 = Sifrele.MD5Olustur(kullaniciformu.sifre);

            using(kahve2020Entities db=new kahve2020Entities())
            {
                var kullaniciVarmi = db.kullanicilar.FirstOrDefault(x=>x.kad==kullaniciformu.kad && x.sifre==sifre1);

                if (kullaniciVarmi !=null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciVarmi.kad, kullaniciformu.BeniHatirla);
                    if (string.IsNullOrEmpty(ReturnUrl)) //return url işlemleri
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("/index", "urunler");
                    }
                    return RedirectToAction("/index", "urunler");
                }

                ViewBag.Hata="Kullanıcı adı veya şifre hatalı!!";
                return View("index");
            }

            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); //oturumdan çıkartır
            return RedirectToAction("index");
        }

    }
}