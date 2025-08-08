using System.Threading.Channels;

namespace SampleConApp
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Base class display method");
        }

    }

    class DerivedClass : BaseClass
    {
    
        public void show()
        {
            Console.WriteLine("Derived class show method");
        }
    }
    class Ex09InheritanceDemo{
        static void Main(string[] args)
        {
            DerivedClass c = new DerivedClass();
            c.show();
            c.Display();
        }
    }
}
  


