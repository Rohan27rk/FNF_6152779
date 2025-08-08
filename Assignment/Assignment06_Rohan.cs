using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    internal class Assignment06_Rohan
    {
        static void Main(string[] args)
        {
            Date(2024, 2, 28);
            Date(2025, 4, 31);
        }

        static bool Date(int year, int month, int date)
        {
            Hashtable Table = new Hashtable();
            Table.Add(1, 31);
            Table.Add(2, 28);
            Table.Add(3, 31);
            Table.Add(4, 30);
            Table.Add(5, 31);
            Table.Add(6, 30);
            Table.Add(7, 31);
            Table.Add(8, 31);
            Table.Add(9, 30);
            Table.Add(10, 31);
            Table.Add(11, 30);
            Table.Add(12, 31);

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Table[2] = 29;
            }
            if (month >= 1 && month <= 12 && date >= 1 && date <= (int)Table[month])
            {
                Console.WriteLine("Valid date");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid date");
                return false;
            }
        }
    }
}
