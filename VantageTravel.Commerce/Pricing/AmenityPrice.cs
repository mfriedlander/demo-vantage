namespace VantageTravel.Commerce.Pricing
{
    public class AmenityPrice
    {
        public object AmenityKey { get; set; }

        public decimal Value { get; set; }

        public AmenityDiscountLevel DiscountLevel { get; set; }
    }
}
