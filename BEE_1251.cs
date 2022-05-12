using System;
using System.Linq;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            var encodedInput = ASCIIEncoding.ASCII.GetBytes(input);
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