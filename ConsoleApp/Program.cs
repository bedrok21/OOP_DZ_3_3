using System;

namespace ConsoleApp;
internal class Program
{ 
    private static void Main(string[] args)
    {
        Converter Ex = new(37.1m,36.8m);
        Console.WriteLine("Input currency you have(UAH, EUR, USD):");
        switch (Console.ReadLine())
        {
            case "UAH":
                Console.WriteLine("Input currency you get(EUR, USD):");
                switch (Console.ReadLine())
                {
                    case "EUR": 
                        Console.WriteLine("Input value(UAH):");
                        Console.WriteLine("You get " + Math.Round(Ex.UahToEur(Convert.ToDecimal(Console.ReadLine())), 2) + " EUR"); break;
                    case "USD": 
                        Console.WriteLine("Input value(UAH):");
                        Console.WriteLine("You get " + Math.Round(Ex.UahToUsd(Convert.ToDecimal(Console.ReadLine())), 2) + " USD"); break;
                    default: break;
                }
                break;
            case "EUR":
                Console.WriteLine("Input value(EUR):");
                Console.WriteLine("You get " + Math.Round(Ex.EurToUah(Convert.ToDecimal(Console.ReadLine())), 2) + " UAH"); break;
            case "USD":
                 Console.WriteLine("Input value(USD):");
                Console.WriteLine("You get " + Math.Round(Ex.UsdToUah(Convert.ToDecimal(Console.ReadLine())), 2) + " UAH"); break;
            default: break;
        }
    }
}