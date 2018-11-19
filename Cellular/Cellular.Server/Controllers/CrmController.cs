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
        // two interfaces
        public CrmController(IClientsManager clientManager)
        {
            _clientManager = clientManager;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginEmployee(string identity,string password)
        {
            _clientManager.LoginEmployee(identity,password);
            return View();
        }

        [HttpGet]
        public ActionResult AddNewClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewClient(Client client)
        {
            var res = _clientManager.AddNewClient(client);
            return View("Index");
        }

        [HttpGet]
        public ActionResult EditClientDetails()
        {
            return View();
        }

        [HttpPut]
        public ActionResult EditClientDetails(Client client)
        {
            _clientManager.EditClient(client);
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteClient(int clientId)
        {
            _clientManager.DeleteClient(clientId);
            return View("Index");
        }
    }
}