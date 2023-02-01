using Microsoft.AspNetCore;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using CarShop;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args).UseStartup<Startap>();
}