﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410919166.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(String name, float? weight)
        {
            var result = "";
            if (weight.HasValue)
            {
                result = weight * 30 + "cc";
            }

            ViewBag.yourName = name;
            ViewBag.result = result;

            return View();
        }
    }
}