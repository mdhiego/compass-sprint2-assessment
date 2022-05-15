using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int daysOfLife = int.Parse(Console.ReadLine());

        int rest = daysOfLife;
        var timeMeasures = new Dictionary<int, string>()
        {
            {365, "ano(s)"},
            {30, "mes(es)"},
            {1, "dia(s)"}
        };

        foreach (var timeMeasure in timeMeasures)
        {
            Console.WriteLine($"{rest / timeMeasure.Key} {timeMeasure.Value}");
            rest %= timeMeasure.Key;
        }
    }
}