using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex01ConsoleIODemo
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();

            Console.WriteLine($"The Inputs are as follows: \n The name entered is {name} \n The address is {address}");
        }
       
    }
}
