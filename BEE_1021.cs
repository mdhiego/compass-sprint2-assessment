using System;

class URI
{
    static void Main(string[] args)
    {
        int multiplier = 100;
        int multipliedAmountOfMoney = (int)(double.Parse(Console.ReadLine()) * multiplier);
        int rest = multipliedAmountOfMoney;

        Console.WriteLine("NOTAS:");

        int[] multipliedBanknotes = { 10000, 5000, 2000, 1000, 500, 200 };
        foreach (var banknote in multipliedBanknotes)
        {
            Console.WriteLine($"{rest / banknote} nota(s) de R$ {(double)banknote / multiplier:F2}");
            rest %= banknote;
        }

        Console.WriteLine("MOEDAS:");

        int[] multipliedCoins = { 100, 50, 25, 10, 5, 1 };
        foreach (var coin in multipliedCoins)
        {
            Console.WriteLine($"{rest / coin} moeda(s) de R$ {(double)coin / multiplier:F2}");
            rest %= coin;
        }
    }
}