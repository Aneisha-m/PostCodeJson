using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace PostCodeJsonTest
{
    public class PostcodeFileManager
    {
        public string Json(string Fileinfo)
        {
            string json;
            using (StreamReader r = new StreamReader(Fileinfo))
            {
                json = r.ReadToEnd();
                              
            }
            return json;
        }
    }
}
