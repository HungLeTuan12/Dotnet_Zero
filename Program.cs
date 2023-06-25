// var builder = WebApplication.CreateBuilder(args);
// builder.WebHost.UseUrls("http://0.0.0.0:5005");
// var app = builder.Build();

// app.MapGet("/", () => "Hello World 2!");

// app.Run();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace hello_asp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Start app");
            // IHostBuilder builder = Host.CreateDefaultBuilder(args);
            // // Cau hinh mac dinh
            // builder.ConfigureWebHostDefaults((webBuilder) =>
            // {
            //     webBuilder.UseStartup<Startup>();
            // });
            // IHost host = builder.Build();
            // host.Run();
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
