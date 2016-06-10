namespace VantageTravel.Customers
{
    public interface ICustomerSelector
    {
        Customer Select(object key);
    }
}
