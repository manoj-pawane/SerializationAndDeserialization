using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeserializationInCSharp
{
    class JSONSerialization
    {
        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome to universe"
            };

            // Convert BlogSites object to JOSN string format  
            string jsonData = JsonConvert.SerializeObject(bsObj);

            Console.WriteLine(jsonData);
        }

        public void JsonDeserialize()
        {
            string json = @"{  
                    'Name': 'Sam',  
                    'Description': 'Welcome to universe'  
            }";

            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
        }

    }

    [DataContract]
    class BlogSites
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
