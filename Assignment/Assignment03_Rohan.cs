using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Assignment 03
 * Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the result based on the operator the user has typed. It should be in a loop until the user specifies to close it.
 */

/*
 * First i have to take 2 double input from users and then i have to parse in double 
 * next is i have to give operations as characters, so that is user choose any characte from +-x/ it will perform that actions 
 * so to give an options i need to take switch cases in that i have to add 4 operations one by one 
 * then i have to break each switch statement
 * Then give e default condition as invalid experation
 * 
 */
namespace Assignments
{
    internal class Assignment03_Rohan
    {
        static void calc()
        {
            bool cont = false;

            do
            {
                Console.WriteLine("Enter the First Number: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second Number: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operations you want to perform:+,-,*,/");
                char ch = char.Parse(Console.ReadLine());

                switch (ch)
                {
                    case '+':
                        Console.WriteLine("Addition is" + (num1 + num2));
                        break;

                    case '-':
                        Console.WriteLine("Substraction is" + (num1 - num2));
                        break;

                    case '*':
                        Console.WriteLine("Multiplication is" + (num1 * num2));
                        break;

                    case '/':
                        if(num2!=0)
                        {
                        Console.WriteLine("Division is" + (num1 / num2));

                        }
                        break;

                    default:
                        Console.WriteLine("Please select \"Correct operation\" to perform");
                        break;

                }
                Console.WriteLine("Do you want to Continue Press y/n");
                char choice = char.Parse(Console.ReadLine().ToLower());
                if (choice == 'y')
                {
                    cont = true;
                }
                else
                {
                    return;
                }

            } while (cont);

        }
           



                
        
        static void Main(string[] args)
        {
            calc();
        }
    }
}
