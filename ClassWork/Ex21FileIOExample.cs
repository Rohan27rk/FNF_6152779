using SampleConApp.CustomCollections;
using System;
using System.IO; //namespace for File IO operations. 

namespace SampleConApp
{
    internal class Ex21FileIOExample
    {
        static void Main(string[] args)
        {
           // displayDirInfo();
            ReadingCSVFile();
            CreatingCSVFile();

        }
        private static void ReadingCSVFile()
        {

            var filePath = "C:\\Users\\6152779\\Desktop\\customer.csv";
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
                var parts = content.Split(',');
                if (parts.Length == 3)
                {
                    var customer = new Customer
                    {
                        CustomerId = int.Parse(parts[0]),
                        CustomerName = parts[1],
                        BillAmount = double.Parse(parts[2])
                    };
                    Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.CustomerName}, Bill Amount: {customer.BillAmount}");
                }
                else
                {
                    Console.WriteLine("Invalid CSV format.");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        private static void CreatingCSVFile()
        {
            var customer = new Customer
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                BillAmount = 100.50
            };
            var filePath = "C:\\Users\\6152779\\Desktop\\customer.csv";
            var content = $"{customer.CustomerId},{customer.CustomerName},{customer.BillAmount}";
            File.WriteAllText(filePath, content);
        }
        private static void displayDirInfo() 
        {

            var files = Directory.GetFiles("C:\\Users\\6152779\\Downloads");
            foreach (var file in files)
            {
                var selected_file = new FileInfo(file);
                Console.WriteLine($"The Name: {selected_file.Name}, Created on {selected_file.CreationTime}");

            }
            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Users\\6152779\\Documents");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
                Console.WriteLine(dir.CreationTime);
            }

            var newDir = "C:\\TestDir";
            var dirInfo = Directory.CreateDirectory(newDir);
            var parent = dirInfo.Parent;
            foreach (var dir_path in directorys)
            {
                var info = new DirectoryInfo(dir_path);
                foreach (var file in info.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }
        }
    }
}

