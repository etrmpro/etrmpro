using etrmpro.CurveAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace etrmpro.CurveAPI.Services
{
    public interface IReferenceDataService
    {
        ICollection<Commodity> FindAllCommodities();
    }

    public class ReferenceDataService : AbstractService, IReferenceDataService
    {
        public ICollection<Commodity> FindAllCommodities()
        {
            return dbContext.Commodities.ToList();
        }
    }
}