using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string[] lines = new string[N];

        for (int i = 0; i < N; i++)
            lines[i] = Console.ReadLine();

        foreach (var line in lines)
        {
            string output = string.Join(" ", line.Split(' ').OrderByDescending(x => x.Length));

            Console.WriteLine(output);
        }
    }
}