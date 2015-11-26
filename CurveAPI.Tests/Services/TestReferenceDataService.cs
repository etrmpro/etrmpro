using Microsoft.VisualStudio.TestTools.UnitTesting;
using etrmpro.CurveAPI.Models;
using System.Collections.Generic;
using etrmpro.CurveAPI.Services;

namespace etrmpro.CurveAPI.Tests
{
    [TestClass]
    public class TestReferenceDataService
    {
        [TestMethod]
        public void TestFindAllCommodities()
        {
            IReferenceDataService service = ServiceFactory.GetReferenceDataService();
            ICollection<Commodity> commodities = service.FindAllCommodities();
            Assert.IsNotNull(commodities);
            Assert.IsTrue(commodities.Count > 0);
        }
    }
}
