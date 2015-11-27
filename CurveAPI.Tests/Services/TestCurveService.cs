using Microsoft.VisualStudio.TestTools.UnitTesting;
using etrmpro.CurveAPI.Models;
using etrmpro.CurveAPI.Services;
using System.Data.Entity.Validation;

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
            curve.MarketId = 1;
            curve.Name = "Test Curve";
            curve = service.SaveOrUpdate(curve);
            Assert.IsNotNull(curve);
            Assert.IsTrue(curve.CurveId >= 1);
            Assert.IsTrue(curve.Name == "Test Curve");
        }

        [TestMethod]
        public void TestAddCurveWithPoint()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = new Curve();
            curve.TenantId = 1;
            curve.MarketId = 1;
            curve.PointId = 1;
            curve.Name = "Test Curve";
            curve = service.SaveOrUpdate(curve);
            Assert.IsNotNull(curve);
            Assert.IsTrue(curve.CurveId >= 1);
            Assert.IsTrue(curve.Name == "Test Curve");
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void TestAddCurveWithInvalidPointId()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = new Curve();
            curve.TenantId = 1;
            curve.MarketId = 1;
            curve.PointId = 1111111;
            curve.Name = "Test Curve";
            curve = service.SaveOrUpdate(curve);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void TestAddCurveWithPointIdNotAssociatedWithMarketId()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = new Curve();
            curve.TenantId = 1;
            curve.MarketId = 1;
            curve.PointId = 2;
            curve.Name = "Test Curve";
            curve = service.SaveOrUpdate(curve);
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

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void TestUpdateCurveWithInvalidPointId()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = service.Find(1);
            curve.Name = "Updated";
            curve.PointId = 123456;
            curve = service.SaveOrUpdate(curve);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void TestUpdateCurveWithPointIdNotAssociatedWithMarketId()
        {
            ICurveService service = ServiceFactory.GetCurveService();
            Curve curve = service.Find(2);
            curve.Name = "Updated";
            curve.PointId = 2;
            curve = service.SaveOrUpdate(curve);
        }
    }
}
