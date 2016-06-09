using System.Collections.Generic;

namespace Vantage.Customers.Search
{
    public class CustomerSearchQuery
    {
        public IEnumerable<CustomerField> Fields { get; set; }
    }
}
