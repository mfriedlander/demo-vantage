using System.Collections.Generic;

namespace VantageTravel.Customers.Search
{
    public class CustomerSearchQuery
    {
        public IEnumerable<CustomerFacet> Fields { get; set; }
    }
}
