﻿using System;
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

     
        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Urunler()
        {
            return View();
        }

        public ActionResult Magaza()
        {
            return View();
        }
    }
}