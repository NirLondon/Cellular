using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cellular.Server.Controllers
{
    public class CrmController : Controller
    {
        private readonly IClientsManager _clientManager;

        // GET: Crm
        public CrmController(IClientsManager clientManager)
        {
            _clientManager = clientManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNewClient()
        {
            return View("AddNewClient");
        }
        [HttpPost]
        public ActionResult AddNewClient(Client client)
        {
            var res = _clientManager.AddNewClient(client);
            return View();
        }

    }
}