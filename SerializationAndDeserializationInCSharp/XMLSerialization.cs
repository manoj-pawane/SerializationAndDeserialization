using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SerializationAndDeserializationInCSharp
{
    class XMLSerialization
    {
        
        public void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"E:\ExampleForXml.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2015, 12, 31);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream, orderForm);
        }

        public void DeserializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"E:\ExampleForXml.txt", FileMode.Open);
            OrderForm data =(OrderForm)ser.Deserialize(fileStream);
            Console.WriteLine(data.OrderDate);
        }
    }

    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
