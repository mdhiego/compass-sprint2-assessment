using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        var answers = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;

            var bytesAndFrequencies = new SortedDictionary<char, int>();
            foreach (char character in input)
            {
                if (bytesAndFrequencies.ContainsKey(character)) bytesAndFrequencies[character]++;
                else bytesAndFrequencies.Add(character, 1);
            }

            var sortedBytesAndFrequencies = bytesAndFrequencies
                .OrderBy(x => x.Value)
                .ThenByDescending(x => x.Key);

            var answer = new StringBuilder();
            foreach (var item in sortedBytesAndFrequencies)
                answer.Append($"{(int)item.Key} {item.Value}\n");

            answers.Add(answer.ToString());
            answers.Add("\n");
        }

        foreach (string answer in answers)
            Console.Write(answer);
    }
}
