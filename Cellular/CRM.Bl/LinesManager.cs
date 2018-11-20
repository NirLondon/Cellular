using Cellular.Common.DTOs;
using Cellular.CRM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Bl
{
    public class LinesManager : ILinesService
    {
        private readonly ILinesRepository _linesRepository;

        public LinesManager(ILinesRepository linesRepository)
        {
            this._linesRepository = linesRepository;
        }

        public Line AddLine(int clientId, Package package)
        {
            throw new NotImplementedException();
        }

        public Package AddNewPackage(List<PackageInclud> packageIncluds)
        {
            Package package = new Package() { PackageIncluds = packageIncluds };
            return _linesRepository.SavePackageToDb(package);
        }

        public bool EditLine(int lineId, Package newPackage)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLine(int lineId)
        {
            throw new NotImplementedException();
        }
    }
}
