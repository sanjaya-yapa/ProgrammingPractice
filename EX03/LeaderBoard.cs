namespace ProgrammingPractice.Ex03
{
    public class LeaderBoard
    {
        public List<int> climbingLeaderBoard(List<int> ranked, List<int> player)
        {
            List<int> distinctScores = ranked.Distinct().OrderByDescending(rank => rank).ToList();
            List<int> playerRanks = new List<int>();

            int index = distinctScores.Count - 1;
            foreach(int score in player)
            {
                // Option 01
                // int rank = 1;
                // foreach(int distinctScore in distinctScores)
                // {
                //     if( score >= distinctScore)
                //     {
                //         break;
                //     }
                //     rank++;
                // }
                // playerRanks.Add(rank);

                // Option 02    
                while(index >= 0 && score >= distinctScores[index])
                {
                    index--;
                }
                playerRanks.Add(index + 2);

            }
            return playerRanks;
        }

        public void Execute()
        {
            List<int> ranked = new List<int> { 100, 90, 90, 80, 75, 60 };
            List<int> player = new List<int> { 50, 65, 77, 90, 102 };

            List<int> result = climbingLeaderBoard(ranked, player);
            Console.WriteLine("Player Ranks: ");
            foreach(int rank in result)
            {
                Console.WriteLine(rank);
            }
        }
    }
}
