﻿using HelloClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var person = new Person() { FirstName = "Alex", LastName = "Mang" };
            ViewBag.Greeting = person.Greet();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}