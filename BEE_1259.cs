using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];

        for (int i = 0; i < N; i++)
            numbers[i] = int.Parse(Console.ReadLine());

        int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
        int[] oddNumbers = numbers.Where(x => x % 2 == 1).ToArray();

        foreach (var evenNumber in evenNumbers.OrderBy(x => x))
            Console.WriteLine(evenNumber);

        foreach (var oddNumber in oddNumbers.OrderByDescending(x => x))
            Console.WriteLine(oddNumber);
    }
}