using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        var lines = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            lines.Add(input);
        }

        foreach (var line in lines)
        {
            var encodedInput = ASCIIEncoding.ASCII.GetBytes(line);
            var bytesWithFrequences = encodedInput
                .Distinct()
                .Select(x => new { Value = x, Count = encodedInput.Count(y => y == x) });
            var orderedOutput = bytesWithFrequences
                .OrderBy(x => x.Count)
                .ThenByDescending(x => x.Value);

            foreach (var item in orderedOutput)
                Console.WriteLine($"{item.Value} {item.Count}");

            Console.WriteLine();
        }
    }
}