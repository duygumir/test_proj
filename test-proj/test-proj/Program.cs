using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_proj
{
    class Program
    {
        public static void Test()
        {
            JObject data = new JObject();

            JArray dataDocuments = new JArray();

            data["Documents"] = dataDocuments;
            data["test"] = "test";
            

            string sData = data.ToString();

        }
        public partial class ManifestResponse
        {
            /// Cevap kodu <remarks/>
            public string ResponseCode { get; set; }

            /// Cevap acıklmasi <remarks/>
            public string ResponseDescription { get; set; }
        }

        public static ManifestResponse GetManifestResponse(int code)
            {
                code = 200;
                ManifestResponse manifestResponse = new ManifestResponse();

                if (code == 0)
                {
                    manifestResponse.ResponseCode = "00";
                    manifestResponse.ResponseDescription = "";
                }
                else
                {

                string responseCodeFirst = "";

                if (code.ToString().Length > 2)
                {
                    //responseCodeFirst = (CommonLib.Helpers.Left((CommonLib.Helpers., 1) + 50).ToString());
                }
                manifestResponse.ResponseCode = CommonLib.Helpers.Right("0" + responseCodeFirst, 2);
            }
                return manifestResponse;
            }
        

        static void Main(string[] args)
        {
            Test();

            int id = 890;
            List<int> ids = new List<int> { 888, 889, 890, 891, 892, 893, 894 };

            if (ids.Contains(id))
            {
                string aayaz = "aaaaa";
                Console.WriteLine(aayaz);
            }

            ManifestResponse manifestResponse = new ManifestResponse();
            manifestResponse = GetManifestResponse(100);
        }
    }
}
