﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HttpApi_Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseBeatPulse(options=>
                {
                    options.DetailedOutput = true; // default is false
                    options.BeatPulsePath = "health"; // default hc
                    options.Timeout = 1500; //default infinite (-1)
                }).UseStartup<Startup>().Build();
    }
}
