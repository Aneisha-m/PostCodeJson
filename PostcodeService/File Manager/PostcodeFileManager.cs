using System;
using System.IO;


using Newtonsoft.Json;

namespace PostCodeJsonTest
{
    public class PostcodeFileManager
    {
        public string Json(string Fileinfo)
        {
            string Json;
            using (var stream = new StreamReader(Fileinfo))
            {
                Json = stream.ReadToEnd();
                              
            }
            return Json;
        }
    }
}
