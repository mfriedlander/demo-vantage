using System.Collections.Generic;
using Vantage.Customers;

namespace Vantage.Trips.Reservations
{
    public interface IReservationSelector
    {
        IEnumerable<Reservation> Select(Customer customer);
    }
}
