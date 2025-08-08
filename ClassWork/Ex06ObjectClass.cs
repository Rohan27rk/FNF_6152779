using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex06ObjectClass
    {
        static void Main(string[] args)
        {
            Object obj = 10;
            Console.WriteLine("The data Type is "+ obj.GetType().Name);
            obj = "Sample text";
            Console.WriteLine("The data Type is " + obj.GetType().Name);
            obj = 1234.56f;
            Console.WriteLine("The data Type is " + obj.GetType().Name);

        }
    }
}
