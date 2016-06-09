namespace Vantage.Trips.Pricing
{
    public class TripDeparturePrice
    {
        public decimal Retail { get; set; }

        public decimal Discout { get; set; }

        public TripDepartureDiscountLevel DiscountLevel { get; set; }
    }
}
