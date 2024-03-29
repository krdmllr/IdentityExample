﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace App2Night.AuthenticationExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "ApiExample";


            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:5001") 
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
