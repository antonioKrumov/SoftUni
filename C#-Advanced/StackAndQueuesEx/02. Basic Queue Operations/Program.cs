using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numbersToEnqueue = inputNumbers[0];
            int numbersToDequeue = inputNumbers[1];
            int numberToBeFound = inputNumbers[2];
            int minValue = int.MaxValue;
            Queue<int> queueOfNumbers = new Queue<int>();
            foreach (var num in numbers)
            {
                queueOfNumbers.Enqueue(num);
            }
            if (queueOfNumbers.Count > 0)
            {
                for (int i = 0; i < numbersToDequeue; i++)
                {
                    queueOfNumbers.Dequeue();
                }
            }
            bool isThere = false;
            if (queueOfNumbers.Count > 0)
            {
                foreach (var num in queueOfNumbers)
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
            if (queueOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            if (!isThere && queueOfNumbers.Count > 0)
            {
                Console.WriteLine(minValue);
            }
            else if (isThere && queueOfNumbers.Count > 0)
            {
                Console.WriteLine("true");
            }
        }
    }
}
