using System;

class URI
{
    static void Main(string[] args)
    {
        var sellerName = Console.ReadLine();
        double baseSalary = double.Parse(Console.ReadLine());
        double totalSales = double.Parse(Console.ReadLine());

        double commission = totalSales * 0.15;
        double salary = baseSalary + commission;

        Console.WriteLine($"TOTAL = R$ {salary:F2}");
    }
}