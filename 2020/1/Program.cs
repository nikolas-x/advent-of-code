using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Read data
        var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var lines = File.ReadAllLines($"{directory}/data/input");
        var entries = Array.ConvertAll(lines, int.Parse);

        // Find two entries that sum to the target
        var target = 2020; // Could be configurable
        var previousEntries = new HashSet<int>();
        int entry1 = 0, entry2 = 0;
        foreach (var entry in entries)
        {
            if (previousEntries.Contains(target - entry))
            {
                entry1 = target - entry;
                entry2 = entry;
                Console.WriteLine($"Entries summing to {target}: {entry1} + {entry2}");
                break;
            }
            previousEntries.Add(entry);
        }

        // Multiply and return
        Console.WriteLine(entry1 > 0 ? $"Result: {entry1 * entry2}" : $"No entries summing to {target}");
    }
}
