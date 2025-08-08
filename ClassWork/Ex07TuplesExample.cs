using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex07TuplesExample
    {
        static void Main(string[] args)
        {
            var myExample = (45, "MyName");
            Console.WriteLine($"First item: {myExample.Item1},secont item: {myExample.Item2}");
            Console.WriteLine("The data type is " + myExample.GetType().Name);

            //U can have named tupples as well

            var person = (Name: "John", age: 30, City: "New york");
            Console.WriteLine($"Name of the person is {person.Name} and he is from {person.City} his age is {person.age}");

            var (longit, latid) = GetCoordinate();
            Console.WriteLine($"The number is {longit} and {latid}");
        }
         
        static (double,double) GetCoordinate()
        {
            return (12.5254, 15.6398);
        }

    }
}
