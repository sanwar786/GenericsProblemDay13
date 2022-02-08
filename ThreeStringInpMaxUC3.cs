﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenricProblemDay13
{
    internal class ThreeStringInpMaxUC3
    {
        //Method to compare three integer numbers to get the maximum values(UC1)
        public static int MaxIntNumThree(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }

        //Method to compare three float numbers to get the maximum values(UC2)
        public static float MaxFloatNumThree(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }

        //Method to compare three string input to get the maximum values(UC3)
        public static string MaxStringThree(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        }
    }
}
