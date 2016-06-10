namespace VantageTravel.Customers.Search
{
    public interface ICustomerSearch
    {
        CustomerSearchResult Search(CustomerSearchQuery query);
    }
}
