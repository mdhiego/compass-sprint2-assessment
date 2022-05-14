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

            var frequencies = new SortedDictionary<char, int>();

            foreach (char character in input)
            {
                if (frequencies.ContainsKey(character)) frequencies[character]++;
                else frequencies.Add(character, 1);
            }

            var sortedFrequencies = frequencies
                .OrderBy(x => x.Value)
                .ThenByDescending(x => x.Key);

            var answer = new StringBuilder();

            foreach (var item in sortedFrequencies)
                answer.Append($"{(int)item.Key} {item.Value}\n");

            answers.Add(answer.ToString());
        }

        for (int i = 0; i < answers.Count; i++)
        {
            Console.Write(answers[i]);
            if (i != answers.Count - 1) Console.Write("\n");
        }
    }
}
