namespace Vantage.Customers.Context
{
    public interface ICustomerContext
    {
        bool IsRecognized { get; }

        object Key { get; }

        void Set(Customer customer);
    }
}
