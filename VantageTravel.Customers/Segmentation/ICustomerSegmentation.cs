namespace VantageTravel.Customers.Segmentation
{
    public interface ICustomerSegmentation
    {
        CustomerSegmentation GetSegmentation(Customer customer);
    }
}
