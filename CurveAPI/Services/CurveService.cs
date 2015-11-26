using etrmpro.CurveAPI.Models;
using System.Data.Entity;

namespace etrmpro.CurveAPI.Services
{
    public interface ICurveService
    {
        Curve Find(int curveId);
        Curve SaveOrUpdate(Curve curve);
    }

    public class CurveService : AbstractService, ICurveService
    {
        public Curve Find(int curveId)
        {
            return dbContext.Curves.Find(curveId);
        }

        public Curve SaveOrUpdate(Curve curve)
        {
            if (curve.GetId() > 0)
            {
                curve = dbContext.Curves.Attach(curve);
                dbContext.Entry(curve).State = EntityState.Modified;
            } else
            {
                curve = dbContext.Curves.Add(curve);
            }
            dbContext.SaveChanges();
            return curve;
        }
    }
}
