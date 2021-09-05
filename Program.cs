using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;


namespace UploadFilesServer_VPS_assist
{
    public class Program
    {
        public static string securepassword;
        public static void RemindUser(){
            while(true){
                var address=PublicIp.PublicIp.GetMyIP();
                System.Console.WriteLine($"HTTPS (safe) website is hosted on: https://{address}:12345\n");
                System.Console.WriteLine($"HTTP (unsafe) website is hosted on: http://{address}:54321\n");
                System.Console.WriteLine($"Password for access is: {Program.securepassword}\n\n");
                Thread.Sleep(5000);
            }
        }
        public static void Main(string[] args)
        {
            byte[] data=new byte[32];
            RNGCryptoServiceProvider.Fill(data);
            securepassword=BitConverter.ToString(data).Replace("-", string.Empty);
            var t1=new Thread(Program.RemindUser);
            t1.Start();
            
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
