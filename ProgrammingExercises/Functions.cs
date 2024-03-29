﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    public static class Functions
    {
        public static void Print<T>(List<T> strings)
        {
            Console.WriteLine("\nResults:");
            foreach (var str in strings)
            {
                Console.WriteLine(str.ToString());
            }
            Console.WriteLine("");
        }

        public static void PrintReverseOrder<T>(List<T> collection)
        {
            Stack<T> stack = new Stack<T>();
            foreach (var item in collection)
            {
                stack.Push(item);
            }
            Print<T>(stack.ToList());
        }

        public static void PrintNumbers(int lower, int upper, PARITY parity)
        {
            if(parity == PARITY.EVEN)
            {
                PrintEvenNumbers(lower, upper);
            }
            else
            {
                PrintOddNumbers(lower, upper);
            }
        }
        
        public static void PrintEvenNumbers(int lower, int upper)
        {
            for (int i = lower; i < upper; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintOddNumbers(int lower, int upper)
        {
            for (int i = lower; i < upper; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintLowestNumber(ICollection<int> numbers)
        {
            var sortedNumbers = (from number in numbers
                                 orderby number ascending
                                 select number);
            if(sortedNumbers != null)
            {
                Console.WriteLine(sortedNumbers.First<int>());
            }
        }
    }

    public enum PARITY
    {
        EVEN,
        ODD
    }
}
