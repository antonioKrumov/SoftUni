using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>();
            foreach (var order in input)
            {
                orders.Enqueue(order);
            }
            int biggestOrder = int.MinValue;
            foreach (var order in orders)
            {
                if (order > biggestOrder)
                {
                    biggestOrder = order;
                }
            }
            while (foodQuantity > 0 && orders.Count > 0)
            {
                int currentOrder = orders.Peek();
                if (foodQuantity - currentOrder < 0)
                {
                    break;
                }
                foodQuantity -= currentOrder;
                orders.Dequeue();
            }
            Console.WriteLine(biggestOrder);
            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
