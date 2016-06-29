using System.Collections.Generic;
using VantageTravel.Customers;

namespace VantageTravel.Web.Customers.Recognition
{
    public interface IRecognitionTracking
    {
        void Track(CustomerFacetType type, string value);

        void Track(CustomerFacet field);

        void Clear();

        IEnumerable<CustomerFacet> GetFields();
    }
}
