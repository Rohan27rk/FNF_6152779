using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SampleConApp
{
    //.Net core uses appsettings.json file to read configuration settings.
    //these settings can be read using the ConfigurationBuilder class.
    //ConfigurationBuilder class is used to build a configuration object that can be used to read the settings from the appsettings.json file.
    //The appsettings.json file is a JSON file that contains the configuration settings for the application.
    //json is the preferred format for configuration settings in .Net core applications.It is easy to read and write, and it is also easy to parse.Json format is also human-readable., which makes it easy to understand the configuration settings.It can be modified easily without the need to recompile the application.
    internal class Ex26ReadingConfig
    {
        public static IConfigurationRoot AppConfig { get; set; }

        static void Main(string[] args)
        {
            //Create a configuration builder
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) //Set the base path to the current directory
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) //Add the appsettings.json file to the configuration builder
                .Build(); //Build the configuration object
            AppConfig = config;
            //Read the settings from the appsettings.json file
            var appName = AppConfig["AppSettings:AppName"]; //Read the AppName setting
            var title = AppConfig["AppSettings:Title"]; //Read the Title setting
            Console.WriteLine($"~~~~~~~~~~~{appName.ToUpper()}~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~~~~~~~~{title.ToUpper()}~~~~~~~~~~~~~~~");
            Console.ReadLine();

            var appSettings = new AppSettings();
            config.GetSection("AppSettings").Bind(appSettings); //Bind the AppSettings section to the AppSettings class
            Console.WriteLine(appSettings.Title);
        }
    }
    class AppSettings
    {
                public string AppName { get; set; }
                public string Title { get; set; }
    }
}

