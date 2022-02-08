using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenricProblemDay13
{
    //Generic class to find maximum values
    internal class MaximumNumber<T> where T : IComparable
    {
        //Generic array
        public T[] GenValue;

        //Using constructor to initialize those variables 
        public MaximumNumber(T[] GenValue)
        {
            this.GenValue = GenValue;
        }

        // Sorting the value in ascending order(UC4)
        public T[] Sort(T[] GenValue)
        {
            Array.Sort(GenValue);
            Array.Reverse(GenValue);
            return GenValue;
        }

        //Generic method to find max value (UC4)
        public T MaxValue(T[] GenValue)
        {
            var sortedValues = Sort(GenValue);
            return sortedValues.ElementAt(0);
        }

        //Extend the max method to take more then three parameters(UC4)
        public T ShowMax()
        {
            var maxValue = MaxValue(this.GenValue);
            return maxValue;
        }
    }
}
