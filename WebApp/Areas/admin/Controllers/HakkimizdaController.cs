using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Areas.admin.Controllers
{
    [Authorize]
    public class HakkimizdaController : Controller
    {
        // GET: admin/Hakkimizda
        public ActionResult Index()
        {
            return View();
        }
    }
}