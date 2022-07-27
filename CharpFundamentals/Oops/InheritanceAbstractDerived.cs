using System;
using System.Collections.Generic;
using System.Text;

namespace CharpFundamentals.Oops
{
    public class InheritanceAbstractDerived : InheritanceAbstract
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public InheritanceAbstractDerived(double length, double width) {
            Length = length;
            Width = width;
        }

        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }
        

    }
}
