﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class IntegerFindMax
    {
 
        public void FindMaxValue(int first, int second, int third)       //UC1 finding max of 3 numbers.
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");
        }
        public void FindMaxValue (float first, float second, float third)    // UC2 Finding maximum Of Three Float
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");

        }
        public void FindMaxValue(string first,string second, string third)    //UC3 Find maximum using Systeam
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine($"{third} is greater ");
            }
            else
                Console.WriteLine("All Numbers are Equal! ");

        }
    }
}
