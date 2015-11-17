using System;

namespace CurveManagement.Models
{
    public class CurveValueDaily
    {
        public int CurveValueDailyId { get; set; }
        public Curve Curve { get; set; }
        public DateTime Date { get; set; }
        public decimal Volume { get; set; }
    }
}