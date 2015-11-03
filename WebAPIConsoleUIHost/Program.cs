using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebAPIConsoleUIHost
{
    class Program
    {
        static void Main(string[] args)
        {
            const string host = "http://localhost:8085";
            var config = new HttpSelfHostConfiguration(host);

            config.Routes.MapHttpRoute(
                "API Default",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine(string.Format("Listing on {0} ...",host));
                Console.WriteLine("WebAPI Server is up an running");
                Console.ReadLine();
            }
        }
    }
}
