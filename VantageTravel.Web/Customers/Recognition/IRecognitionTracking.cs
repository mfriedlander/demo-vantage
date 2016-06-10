using System.Collections.Generic;
using VantageTravel.Customers;

namespace VantageTravel.Web.Customers.Recognition
{
    public interface IRecognitionTracking
    {
        void Track(CustomerFieldType type, string value);

        void Track(CustomerField field);

        void Clear();

        IEnumerable<CustomerField> GetFields();
    }
}
