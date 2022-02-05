using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbersInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numberOfPushes = input[0];
            int numberOfPops = input[1];
            int numberToBeFound = input[2];
            int minValue = int.MaxValue;
            Stack<int> stackOfNumbers = new Stack<int>();
            foreach (var num in numbersInput)
            {
                stackOfNumbers.Push(num);
            }
            if (stackOfNumbers.Count > 0)
            {
                for (int i = 0; i < numberOfPops; i++)
                {
                    stackOfNumbers.Pop();
                }
            }
            bool isThere = false;
            if (stackOfNumbers.Count > 0)
            {
                foreach (var num in stackOfNumbers)
                {
                    if (num == numberToBeFound)
                    {
                        isThere = true;
                    }
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
            }

            if (stackOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (!isThere && stackOfNumbers.Count > 0)
            {
                Console.WriteLine(minValue);
            }
            else if (isThere && stackOfNumbers.Count > 0)
            {
                Console.WriteLine("true");
            }
        }
    }
}
