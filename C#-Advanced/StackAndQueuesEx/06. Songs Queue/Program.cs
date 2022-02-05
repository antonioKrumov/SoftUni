using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> playlist = new Queue<string>();
            foreach (var song in input)
            {
                playlist.Enqueue(song);
            }
            while (playlist.Count != 0)
            {
                string line = Console.ReadLine();
                string[] command = line.Split(' ');

                if (command[0] == "Play")
                {
                    playlist.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string song = line.Substring(4);
                    if (!playlist.Contains(song))
                    {
                        playlist.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ", playlist));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
