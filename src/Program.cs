using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyBp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
                .UseAzureAppServices()
                .UseKestrel(o => o.AddServerHeader = false)
                .UseDefaultServiceProvider(o => o.ValidateScopes = true)
                .UseStartup<Startup>()
                .Build();
    }
}
