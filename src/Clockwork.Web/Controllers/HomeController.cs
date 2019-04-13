﻿using Clockwork.Web.Models;
using System;
using System.Web.Mvc;

namespace Clockwork.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            var model = new HomeViewModel();

            return View(model);
        }
    }
}
