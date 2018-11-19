using Bi.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cellular.Server.Controllers
{
    public class BiController : Controller
    {
        private readonly IReportManager _reportManager;

        public BiController(IReportManager reportManager)
        {
            this._reportManager = reportManager;
        }
        // GET: Bi
        public ActionResult Index()
        {
            return View();
        }
    }
}