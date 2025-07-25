using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment04_Rohan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Type of an array: (int, double, string)");
            string type = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the size of an array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Size of an array is {size}");
            Console.WriteLine($"Enter the {size} values");

            switch (type){

                case "int":

                    int[] IntArray = new int[size];
                    for (int i = 0;i< size; i++)
                    {
                        Console.WriteLine($"Element {i+1}:");
                        IntArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elements are:");

                    foreach (int i in IntArray)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case "double":

                    double[] DoubleArray = new double[size];
                    for (int i = 0;i< size; i++)
                    {
                        Console.WriteLine($"Element {i+1}:");
                        DoubleArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Elements are:");

                    foreach (double i in DoubleArray)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case "string":

                    string[] stringArray = new string[size];
                    for (int i = 0;i< size; i++)
                    {
                        Console.WriteLine($"Element {i+1}:");
                        stringArray[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Elements are:");

                    foreach (string i in stringArray)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;


            }
        }
    }
}
