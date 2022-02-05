using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                truckTour.Enqueue(input);
            }

            int startIndex = 0;
            while (true)
            {
                int truckPetrol = 0;
                foreach (var info in truckTour)
                {
                    int currentPetrol = info[0];
                    int currentDistance = info[1];

                    truckPetrol += currentPetrol;
                    truckPetrol -= currentDistance;
                    if (truckPetrol < 0)
                    {
                        int[] element = truckTour.Dequeue();
                        truckTour.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }
                if (truckPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
