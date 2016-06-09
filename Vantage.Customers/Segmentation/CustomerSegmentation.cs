namespace Vantage.Customers.Segmentation
{
    public class CustomerSegmentation
    {
        public int PreviousTrips { get; set; }

        public CustomerSegmentationFrequency Frequency { get; set; }

        public CustomerSegmentationRecency Recency { get; set; }

        public CustomerSegmentationDiscount Discount { get; set; }
    }
}
