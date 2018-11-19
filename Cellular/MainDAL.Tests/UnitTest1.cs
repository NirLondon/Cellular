using System;
using System.Linq;
using Cellular.MainDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainDAL.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var context = new CellularContext())
            {
                var e = context.Employees.First();
            }
        }
    }
}
