namespace SampleConApp
{
    /*
     * All the data types in C# is bases on common type system of .NET Framework.
     * CTS provides all the common set of data types for all languages of .NET.
     * They are broadly classified as primitive data types(Structs) and reference types(classes).
     * Primitive types are common among all languages: They are also called as VALUE TYPES.
     */
    internal class Ex02DataTypes
    {
        static void Main(string[] args)
        {
            int iVal = 123;
            long lVal = 1234567;
            float fVal = 10.32f;
            double dVal = 12.321456;
            char strVal = 'a';// use single quotes.
            bool bVal = true;

            Console.WriteLine("The value of iVal is {0} \nThe value of lVal is {1} \n The value of fVal is {2} \n the value of fVal is {3} \n The value of strVal is {4} \n the value of bVal is {5}\n", iVal,lVal,fVal,dVal,strVal,bVal);
            //DisplayUSerDetails();
            TypeCastingExample();
        }
        static void DisplayUSerDetails()
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int iAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Mobile no.");
            long lMobile = long.Parse(Console.ReadLine());

            Console.WriteLine($"Name is {name}, The age is {iAge}, the Mobile no is {lMobile} \n");

            Console.WriteLine("Name is {0}, The age is {1}, the Mobile no is {2}",name,iAge,lMobile);

            
        }

        static void TypeCastingExample()
        {
            int iVal = 123;
            long lVal = iVal;
            double dVal = 123.723;
            lVal = (long)dVal;
           // lVal = Convert.ToInt32(dVal);
            Console.WriteLine(lVal);
        }
    }
}