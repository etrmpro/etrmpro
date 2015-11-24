using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurveService.Services;
using CurveService.Models;
using System.Collections.Generic;

namespace CurveService.Tests.Services
{
    [TestClass]
    public class TestCurveService
    {
        [TestMethod]
        public void TestFindAllCommodities()
        {
            ICurveService curveService = ServiceFactory.GetCurveService();
            ISet<Commodity> commodities = curveService.FindAllCommodities();
            Assert.IsNotNull(commodities);
            Assert.IsTrue(commodities.Count > 0);
        }
    }
}
