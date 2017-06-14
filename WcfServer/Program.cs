using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8080/DataService";

            using (var host = new ServiceHost(typeof (DataService), new Uri(baseAddress)))
            {
                var endpoint = host.AddServiceEndpoint(typeof(IDataService), new BasicHttpBinding(), "");

                var smb = new ServiceMetadataBehavior         //when adding meta data behavior, make sure host base address is mex address
                {
                    HttpGetEnabled = true
                };

                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("WCF Data Service is running");
                Console.ReadKey();
            }
        }
    }
}
