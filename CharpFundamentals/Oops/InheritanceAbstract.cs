using System;
using System.Collections.Generic;
using System.Text;

namespace CharpFundamentals.Oops
{
    public abstract class InheritanceAbstract
    {
        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public static double GetArea(InheritanceAbstract shape) //Static members/methods are defined thing, it will depend on other members/methods in the class and static method can only static properties and static variables
        { 
            return shape.Area; 
        }


        public static double GetPerimeter(InheritanceAbstract shape) { return shape.Perimeter; }
    }
}
