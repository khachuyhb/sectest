using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Builder;

namespace ShoesLover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    
                    /*webBuilder.UseKestrel(kestrelServerOptions =>
                    {
                        kestrelServerOptions.Listen(IPAddress.Any, 8090);
                        kestrelServerOptions.ListenLocalhost(8091);
                        kestrelServerOptions.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(2);
                        // Các thiết lập cho Kestrel tại đây
                        // sử dụng KestrelServerOptons để thiết lập
                    });
                    webBuilder.UseUrls("http://0.0.0.0:8090", "https://0.0.0.0:8091");
                    webBuilder.UseUrls("http://0.0.0.0:5000");*/
                    webBuilder.UseStartup<Startup>();
                   
                });

    }
}
