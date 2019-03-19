using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PostCodeJsonTest
{
    public class PostcodeDTO
    {
        public Rootobject rootobject { get; set; }
        public int status { get; set; }
        public Result result { get; set; }
        public object Postcode { get; private set; }

        public void DeserializePostcode(string PostcodeResponse)
        {
            Postcode = JsonConvert.DeserializeObject<RootObject>(PostcodeResponse);
        }
    }
}
