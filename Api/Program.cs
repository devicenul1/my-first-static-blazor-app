using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using System;

namespace ApiIsolated
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults(builder =>
                {
                    // builder
                    //     .Services
                    //         .addop
                    //         .AddMicrosoftIdentityWebApiAuthentication(Environment.get System.Configuration.GetSection("AzureAd"));
                })
                .ConfigureServices(s =>
                {
                })
                .Build();

            host.Run();

            host.Services.add
        }
    }
}