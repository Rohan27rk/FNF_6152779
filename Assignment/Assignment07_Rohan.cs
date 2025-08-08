using System;

namespace Assignment
{
    internal class Assignment07_Rohan
    {
        static void Main()
        {
            int[] Sample = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

            foreach (int num in Sample) {
                bool result = IsPrimeNumber(num);
                Console.WriteLine(result);
            }
        }

        static bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
