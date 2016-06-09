namespace Vantage.Customers.Segmentation
{
    public interface ICustomerSegmentation
    {
        CustomerSegmentation GetSegmentation(Customer customer);
    }
}
