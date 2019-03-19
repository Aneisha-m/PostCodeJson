using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PostCodeJsonTest
{
    public class PostcodeService
    {
        public PostcodeService postcodeService = new PostcodeService();
        public PostcodeFileManager PostcodeFileManager = new PostcodeFileManager();
        public PostcodeDTO postCodeDTO = new PostcodeDTO();
        public JObject PostCodeJson;
       
        public PostcodeService()
        {
            postCodeDTO.DeserializePostcode(PostcodeFileManager.Json(@"C:\Users\tech-w101.LAPTOP-L2EC9EQP\source\repos\PostCodeJsonTest\PostCodeJsonTest\Resources\Postcode.json"));
            PostCodeJson = JObject.Parse(PostcodeFileManager.Json(@"C:\Users\tech-w101.LAPTOP-L2EC9EQP\source\repos\PostCodeJsonTest\PostCodeJsonTest\Resources\Postcode.json"));
        }
    }
}
