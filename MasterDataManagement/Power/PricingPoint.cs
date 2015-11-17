namespace MasterDataManagement.Power
{
    public class PricingPoint
    {
        public int PricingPointId { get; set; }
        public int ISOId { get; set; }
        public ISO ISO { get; set; }
        public PricingPointType PricingPointType { get; set; }
        public string Name { get; set; }
    }
}
