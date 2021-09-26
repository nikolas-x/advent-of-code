using System;
using System.IO;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var lines = File.ReadAllLines($"{directory}/data/input");
        var entries = Array.ConvertAll(lines, int.Parse);
        Array.ForEach(entries, Console.WriteLine);
    }
}
