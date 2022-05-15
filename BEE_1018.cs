using System;

class URI
{
    static void Main(string[] args)
    {
        int amountOfMoney = int.Parse(Console.ReadLine());

        Console.WriteLine(amountOfMoney);

        int rest = amountOfMoney;
        int[] banknotes = { 100, 50, 20, 10, 5, 2, 1 };

        foreach (var banknote in banknotes)
        {
            Console.WriteLine($"{rest / banknote} nota(s) de R$ {banknote},00");
            rest %= banknote;
        }
    }
}