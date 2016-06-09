namespace Vantage.Customers.Search
{
    public interface ICustomerSearch
    {
        CustomerSearchResult Search(CustomerSearchQuery query);
    }
}
