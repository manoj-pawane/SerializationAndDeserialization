using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserializationInCSharp
{
    class BinarySerialzation
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"E:\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }

        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"E:\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName { deserializedSampledemo.ApplicationName} --- ApplicationId       { deserializedSampledemo.ApplicationId}");
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
