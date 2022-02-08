﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenricProblemDay13
{
    //Refactored the code to create generic class to take three variabes of generic type(Ref2)
    internal class MaxNumber<T> where T : IComparable
    {
        //Three generic variables
        public T firstValue, secondValue, thirdValue;

        //Using constructor to initialize those variables 
        public MaxNumber(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        //Refactored all the 3 method to one generic method and finding the maximum values(Ref1)
        private static T ShowMaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }

        //Generic method to call max method which take three parameters
        public T ShowMax()
        {
            T maxValue = MaxNumber<T>.ShowMaxValue(this.firstValue, this.secondValue, this.thirdValue);
            return maxValue;
        }

    }
}