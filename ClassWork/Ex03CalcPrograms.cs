using System;


namespace SampleConApp
{
    internal class Ex03CalcPrograms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the Operator (+,-,*,/)");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '+':
            
                Console.WriteLine(num1 + num2);
                    break;
            
                case '-':
                Console.WriteLine(num1 - num2);
                    break;

                case '*':
                    Console.WriteLine(num1 * num2);
                    break;

                case '/':
                    Console.WriteLine(num1 / num2);
                    break;

            }
        }
    }
}
