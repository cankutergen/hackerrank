public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
            List<int> playerPositions = new List<int>();
            var distinctRanked = ranked.Distinct().ToList();

            int i = distinctRanked.Count - 1;
            foreach (var score in player)
            {
                while (i >= 0)
                {
                    if (score >= distinctRanked[i]) i--;
                    else 
                    {
                        playerPositions.Add(i + 2);
                        break; 
                    }
                }
                if (i < 0) playerPositions.Add(1);
            }
            return playerPositions;
    }
    
