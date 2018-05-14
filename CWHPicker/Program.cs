using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace CWHPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var webHost = WebHost.CreateDefaultBuilder(args);
            if (args != null)
            {
                webHost.UseConfiguration(new ConfigurationBuilder().AddCommandLine(args).Build());
            }
            return webHost.UseStartup<Startup>()
                .ConfigureAppConfiguration((context, config) =>
                {
                    var env = context.HostingEnvironment;

                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                }).Build();
        }
    }
}
