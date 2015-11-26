using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;
using System.IO;
using etrmpro.CurveAPI.Models;

namespace CurveService.Tests
{
    [TestClass]
    public class AssemblyInitialize
    {
        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            AppDomain.CurrentDomain.SetData(
              "DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ""));
            Database.SetInitializer<CurveServiceDbContext>(new ApplicationDbContextInitializer());
            CurveServiceDbContext dbContext = new CurveServiceDbContext();
            dbContext.Database.Initialize(true);
        }
    }
}
