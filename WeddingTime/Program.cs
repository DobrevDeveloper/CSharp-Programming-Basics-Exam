using System;

namespace WeddingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double champagneQuantity = double.Parse(Console.ReadLine());
            double wiskeyQuantity = double.Parse(Console.ReadLine());

            double champagnePrice = wiskeyPrice * 0.5;
            double winePrice = champagnePrice * 0.4;
            double waterPrice = champagnePrice * 0.1;

            double champagneSum = champagneQuantity * champagnePrice;
            double wineSum = wineQuantity * winePrice;
            double waterSum = waterQuantity * waterPrice;
            double wiskeySum = wiskeyQuantity * wiskeyPrice;

            double sum = champagneSum + wineSum + waterSum + wiskeySum;

            Console.WriteLine($"{sum:F2}");
            
        }
    }
}
