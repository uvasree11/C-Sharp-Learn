using System;
using CharpFundamentals.Oops;

namespace InheritanceCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class testInternalInheritance : Inheritance
    {
        public void testInternalInheritanceMethod()
        {
            //Console.WriteLine(count); //We can't access internal value  of base class outside the assmebly
            Console.WriteLine(check);//We can access public value of base class in outside the assembly
            Console.WriteLine(multiple);//We can access protected value of base class in ousided the assembly
        }
    }
}
