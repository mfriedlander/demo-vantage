using VantageTravel.Customers;
using VantageTravel.Trips;

namespace VantageTravel.Commerce.Pricing
{
    public interface IPricingEngine
    {
        DeparturePrice Price(TripDeparture departure, Customer customer);

        DeparturePrice Price(TripDeparture departure);

        TripPrice Price(Trip trip, Customer customer);

        TripPrice Price(Trip trip);
    }
}
