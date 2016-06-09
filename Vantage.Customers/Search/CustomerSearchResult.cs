using System.Collections.Generic;

namespace Vantage.Customers.Search
{
    public class CustomerSearchResult
    {
        public int Count { get; set; }

        public IEnumerable<object> Keys { get; set; }
    }
}
