using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace secondApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();
            var host = new WebHostBuilder()
            .UseKestrel()
               // .UseUrls("http://localhost:5002")
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseIISIntegration()
                                .UseStartup<Startup>()
            .UseApplicationInsights()
            .Build();
             
        host.Run();
        }

        //public static IWebHost BuildWebHost(string[] args)
        //{
        //    return WebHost.CreateDefaultBuilder(args)
        //                       .UseUrls("localhost:5005")
        //                    .UseStartup<Startup>()
        //                    .Build();
        //}

    }
}
