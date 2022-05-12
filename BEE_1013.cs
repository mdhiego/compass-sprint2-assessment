using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        (int a, int b, int c) = (inputNumbers[0], inputNumbers[1], inputNumbers[2]);
        
        int m1, m2;

        m1 = (a + b + (Math.Abs(a - b))) / 2;
        m2 = (c + m1 + (Math.Abs(c - m1))) / 2;

        Console.WriteLine($"{m2} eh o maior");
    }
}