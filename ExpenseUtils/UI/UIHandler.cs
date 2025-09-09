using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AssignmentProject.UI
{
    public static class UIHandler
    {
        public static void DisplayMenu()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var welcome_contents = config["FileSettings:FilePath"];
            if (string.IsNullOrEmpty(welcome_contents))
            {
                Console.WriteLine("Menu file not found or empty.");
                return;
            }
            var menuFilePath = Path.Combine(Directory.GetCurrentDirectory(), welcome_contents);
            if (!File.Exists(menuFilePath))
            {
                Console.WriteLine("Menu file does not exist.");
                return;
            }
            var menuContents = File.ReadAllText(menuFilePath);
            Console.WriteLine(menuContents);

        }
    }
}
