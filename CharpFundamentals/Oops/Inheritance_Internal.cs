using System;
using System.Collections.Generic;
using System.Text;

namespace CharpFundamentals.Oops
{
    class Inheritance_Internal:Inheritance
    {
        public void getInternalValueSameAssembly()
        {
            Console.WriteLine(count);//Internal value can be used inside same assmbly and dervied class
        }
    }
}
