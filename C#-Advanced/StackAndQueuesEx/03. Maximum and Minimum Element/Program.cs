using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Stack<int> sequense = new Stack<int>();
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            for (int i = 0; i < lines; i++)
            {
                int[] query = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int queryNumber = query[0];
                if (queryNumber == 1)
                {
                    int numberToPush = query[1];
                    sequense.Push(numberToPush);
                }
                else if (queryNumber == 2)
                {
                    if (sequense.Count > 0)
                    {
                        sequense.Pop();
                    }
                }
                else if (queryNumber == 3)
                {
                    foreach (var num in sequense)
                    {
                        if (num > maxValue)
                        {
                            maxValue = num;
                        }
                    }
                    if (sequense.Count > 0)
                    {
                        Console.WriteLine(maxValue);
                    }
                }
                else if (queryNumber == 4)
                {
                    foreach (var num in sequense)
                    {
                        if (num < minValue)
                        {
                            minValue = num;
                        }
                    }
                    if (sequense.Count > 0)
                    {
                        Console.WriteLine(minValue);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", sequense));
        }
    }
}
