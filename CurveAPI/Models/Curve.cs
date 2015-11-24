namespace CurveService.Models
{
    public class Curve : AbstractMultitenantEntity
    {
        public int CurveId { get; set; }
        public string Name { get; set; }
    }
}
