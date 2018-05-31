using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyBp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(o => o.AddServerHeader = false)
                .UseDefaultServiceProvider(o => o.ValidateScopes = true)
                .UseStartup<Startup>();
    }
}
