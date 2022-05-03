using System;

namespace BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double moneyMadePerDay = double.Parse(Console.ReadLine());
            double expense = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalMoney = 5 * moneyPerDay;
            double totalMadedMoney = 5 * moneyMadePerDay;
            double totalSum = totalMoney + totalMadedMoney - expense;

            if(totalSum >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalSum:F2} BGN, the gift has been purchased.");
            }

            else
            {
                double sumNeeded = giftPrice - totalSum;
                Console.WriteLine($"Insufficient money: {sumNeeded:F2} BGN.");
            }
        }
    }
}
