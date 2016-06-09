namespace Vantage.Customers.Context
{
    public interface ICustomerContext
    {
        bool IsRecognized { get; }

        Customer Current { get; }

        void Set(Customer customer);
    }
}
