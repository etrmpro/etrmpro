using etrmpro.CurveAPI.Models;
using System.Data.Entity;

namespace etrmpro.CurveAPI.Services
{
    public class AbstractService
    {
        public CurveServiceDbContext dbContext = new CurveServiceDbContext();
    }

    public class ServiceFactory
    {
        public static ICurveService GetCurveService()
        {
            return new CurveService();
        }
        public static IReferenceDataService GetReferenceDataService()
        {
            return new ReferenceDataService();
        }
    }
}
