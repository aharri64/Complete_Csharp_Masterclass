using System;

namespace IfStatementChallenge2
{
    class Program
    {
        static int highScore = 300;
        static string highScorePlayer = "Amir";

        static void Main(string[] args)
        {
            PlayerScore(250, "Stormy");
            PlayerScore(400, "Charlee");
            PlayerScore(500, "Amir");
            PlayerScore(500, "Charlee");
        }

        public static void PlayerScore(int score, string playerName)
        {
            
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine($"The new high score is {highScore} by {highScorePlayer}");
            }
            else if (score == highScore)
            {
                Console.WriteLine($"{playerName} scored the same score as {highScorePlayer}");
            }
            else
            {
                Console.WriteLine($"{playerName}'s score was not high enough, try again");                
            }
        }
    }
}
