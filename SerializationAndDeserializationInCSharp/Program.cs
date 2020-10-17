using System;

namespace SerializationAndDeserializationInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialzation binarySerialzation = new BinarySerialzation();
            XMLSerialization xMLSerialization = new XMLSerialization();
            JSONSerialization jSONSerialization = new JSONSerialization();
            // binarySerialzation.Serialization();
            //binarySerialzation.DeSerialization();
            //XMLSerialization xMLSerialization = new XMLSerialization();
            //xMLSerialization.SerializeDataSet("dataFile");

            //jSONSerialization.JsonSerialize();
            //jSONSerialization.JsonDeserialize();
            //xMLSerialization.SerializeXml();
            xMLSerialization.DeserializeXml();
        }
    }
}
