using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Assignment 2
 * Write a function that takes an array of numbers and it should display the Odd and Even numbers
 */

/*
 * First i will take size of the array from the user
 * Next i have to take each elements from the user so for that i have to run a for loop to add each elements in array.
 * Now what i will do is i will take another for each loop to print each element in array
 * Next is i want to print even and odd numbers in array so i will take a new funtion for that.
 * In that function i will take 1 for each loop to access the elements in array and then take 2 if loops one is for even and odd in side that if i will write condition and print the numbers and call that method in main method.
 */
namespace Assignments
{
    internal class Assignment02_Rohan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers Of an Array");
            int[] array = new int[size1];

            for (int i = 0; i < size1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array elements are: ");
            foreach (int i in array)
            {

                Console.WriteLine(i);
            }
            EvenOdd(array);
        }

        static void EvenOdd(int[] array)
        {
            Console.WriteLine("Even numbers are: ");

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even number");
                }

                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " is odd number");
                }

            }
        }
    }
}



