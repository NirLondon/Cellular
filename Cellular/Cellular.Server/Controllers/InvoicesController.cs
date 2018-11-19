using Cellular.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cellular.Server.Controllers
{
    public class InvoicesController : Controller
    {
        [HttpGet]
        public ActionResult Simulator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Simulator(Call call)
        {
            return View();
        }
    }
}