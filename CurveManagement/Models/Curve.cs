using System.Collections.Generic;

namespace CurveManagement.Models
{
    public class Curve
    {
        public int CurveId { get; set; }
        public InstrumentType InstrumentType { get; set; }
        public CurveSource CurveSource { get; set; }
        public ValueRecurrence ValueRecurrence { get; set; }
        public string Name { get; set; }
        public IList<CurveTag> CurveTags { get; set; }
    }
}