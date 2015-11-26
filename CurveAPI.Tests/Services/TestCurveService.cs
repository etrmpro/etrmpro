using Microsoft.VisualStudio.TestTools.UnitTesting;
using etrmpro.CurveAPI.Models;
using etrmpro.CurveAPI.Services;

namespace etrmpro.CurveAPI.Tests
{
    [TestClass]
    public class TestCurveService
    {
        [TestMethod]
        public void TestAddCurve()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = new Curve();
            curve.TenantId = 1;
            curve.Name = "Test Curve";
            curve = service.SaveOrUpdate(curve);
            Assert.IsNotNull(curve);
            Assert.IsTrue(curve.CurveId >= 1);
            Assert.IsTrue(curve.Name == "Test Curve");
        }

        [TestMethod]
        public void TestUpdateCurve()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = service.Find(1);
            curve.Name = "Updated";
            curve = service.SaveOrUpdate(curve);
            Assert.IsNotNull(curve);
            Assert.IsTrue(curve.CurveId == 1);
            Assert.IsTrue(curve.Name == "Updated");
        }
    }
}
