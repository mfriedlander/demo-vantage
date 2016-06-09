using System.Collections.Generic;

namespace Vantage.Customers.Recognition
{
    public interface IRecognitionTracking
    {
        void Track(CustomerFieldType type, string value);

        void Track(CustomerField field);

        void Clear();

        IEnumerable<CustomerField> GetFields();
    }
}
