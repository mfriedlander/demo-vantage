namespace Vantage.Customers
{
    public interface ICustomerSelector
    {
        Customer Select(object key);
    }
}
