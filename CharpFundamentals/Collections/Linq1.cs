using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CharpFundamentals.Oops;

namespace CharpFundamentals.Collections
{
    class Linq1
    {
        public void LinqLearning() {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<int> selectedResult = from number in numbers where number >= 3 select number;
            foreach(var no in selectedResult)
            {
                Console.WriteLine(no);
            }
                }
    }
    public class inhertitanceDiffAssembly : Inheritance
    {
        public void getInternalDiffAssembly()
        {
            Console.WriteLine(count);
        }
    }
}
