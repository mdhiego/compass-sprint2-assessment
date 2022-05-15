using System;

class URI
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split(' ');
        var product1 = (
            Code: int.Parse(input1[0]), 
            NumberOfUnits: int.Parse(input1[1]), 
            Price: double.Parse(input1[2]));
        
        string[] input2 = Console.ReadLine().Split(' ');
        var product2 = (
            Code: int.Parse(input2[0]), 
            NumberOfUnits: int.Parse(input2[1]), 
            Price: double.Parse(input2[2]));

        double totalPrice = product1.NumberOfUnits * product1.Price + product2.NumberOfUnits * product2.Price;

        Console.WriteLine($"VALOR A PAGAR: R$ {totalPrice:F2}");
    }
}