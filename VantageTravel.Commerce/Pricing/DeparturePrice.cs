using System.Collections.Generic;

namespace VantageTravel.Commerce.Pricing
{
    public class DeparturePrice
    {
        public object DepartureKey { get; set; }

        public IEnumerable<AmenityPrice> AmenitiePrices { get; set; }

        public DepartureDiscountLevel DiscountLevel { get; set; }
    }
}
