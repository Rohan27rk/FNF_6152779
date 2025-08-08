using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class SuperClass()
    {
        public SuperClass(string value) : this()
        {
            Console.WriteLine(value);
        }
    }
    class Baseclass : SuperClass
    {
        public Baseclass(string msg) : base(msg)
        {
            Console.WriteLine("this is base class constructor");
        }

    }
    internal class Ex15Constructors
    {
        static void Main(string[] args)
        {
            BaseClass baseclass = new BaseClass();
        }
    }
}

