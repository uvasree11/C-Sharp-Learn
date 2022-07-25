using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
}
