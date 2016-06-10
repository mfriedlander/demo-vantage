using System.Collections.Generic;
using VantageTravel.Customers;

namespace VantageTravel.Trips.Reservations
{
    public interface IReservationSelector
    {
        IEnumerable<Reservation> Select(Customer customer);
    }
}
