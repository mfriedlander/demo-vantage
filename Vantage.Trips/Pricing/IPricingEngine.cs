using Vantage.Customers;

namespace Vantage.Trips.Pricing
{
    public interface IPricingEngine
    {
        TripDeparturePrice Price(TripDeparture departure);

        TripDeparturePrice Price(TripDeparture departure, Customer customer);

        TripPrice Price(Trip trip);

        TripPrice Price(Trip trip, Customer customer);
    }
}
