using System;
using Newtonsoft.Json;

namespace PostCodeJsonTest
{
    public class PostcodeDTO
    {
        public Rootobject postcodeobject { get; set; }
        public Result result { get; set; }
        

        public void DeserializePostcode(string PostcodeResponse)
        {
            postcodeobject = JsonConvert.DeserializeObject<Rootobject>(PostcodeResponse);
            result = postcodeobject.result;
        }
    }
}
