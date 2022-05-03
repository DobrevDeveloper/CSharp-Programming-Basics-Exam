using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menCount = int.Parse(Console.ReadLine());
            int womanCount = int.Parse(Console.ReadLine());
            int maxCountTables = int.Parse(Console.ReadLine());
            int countTables = 0;

            for (int countMen = 1; countMen <= menCount; countMen++)
            {
                for (int countWoman = 1; countWoman <= womanCount; countWoman++)
                {
                    countTables++;
                    
                    Console.Write($"({countMen} <-> {countWoman}) ");

                    if (countTables == maxCountTables)
                    {
                        return;
                    }
                }
            }
        }
    }
}
