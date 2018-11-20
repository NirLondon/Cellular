using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cellular.Server.Controllers
{
    public class LinesController : Controller
    {
        private bool _minutesPackage;
        private bool _friendsPackage;
        private readonly ILinesService _linesService;

        public LinesController(ILinesService linesService)
        {
            _linesService = linesService;
        }

        // GET: Lines
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddLineToClient(int clientId,short minutesMax,string firstFriendName, string secondFriendName, string thirdFriendName)
        {
            List<PackageInclud> packageIncluds = new List<PackageInclud>();
            if (_minutesPackage)
            {
                packageIncluds.Add(new MinutesBank() { MaxMinutes = minutesMax });
            }
            if (_friendsPackage)
            {
                packageIncluds.Add(new FavoriteFriends()
                {
                    Number1 = firstFriendName,
                    Number2 = secondFriendName,
                    Number3 = thirdFriendName,

                });
            }
            Package package = _linesService.AddNewPackage(packageIncluds);


            var newLine = _linesService.AddLine(clientId, package);
        }
    }
}