﻿using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agents()
        {
            return View();
        }

        public ActionResult AgentAdmin()
        {
            return View();
        }
    }
}