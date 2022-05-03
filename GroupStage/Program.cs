using System;

namespace GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());
            int points = 0;
            int countScoredGoals = 0;
            int countReceivedGoals = 0;

            for(int count = 1; count <= playedGames; count++)
            {
                int scoredGoals = int.Parse(Console.ReadLine());
                int receivedGoals = int.Parse(Console.ReadLine());
                countScoredGoals += scoredGoals;
                countReceivedGoals += receivedGoals;

                if(scoredGoals > receivedGoals)
                {
                    points += 3;
                }

                else if(scoredGoals == receivedGoals)
                {
                    points += 1;
                }
            }

            int goalDifference = countScoredGoals - countReceivedGoals;

            if (countScoredGoals >= countReceivedGoals)
            {
                
                Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }

            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }
        }
    }
}
