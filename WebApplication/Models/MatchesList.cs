using System.Collections.Generic;

namespace WebApplication.Models
{
    public class MatchesList : List<Match>
    {
        public MatchesList()
        {
            AddRange(new[] {
                new Match { TeamHome = "Arsenal", ScoreHome = 4, ScoreAway = 1, TeamAway = "West Brom" },
                new Match { TeamHome = "Aston Villa", ScoreHome = 0, ScoreAway = 1, TeamAway = "Burnley" },
                new Match { TeamHome = "Chelsea", ScoreHome = 3, ScoreAway = 1, TeamAway = "Sunderland" },
                new Match { TeamHome = "Crystal Palace", ScoreHome = 1, ScoreAway = 0, TeamAway = "Swansea City" },
                new Match { TeamHome = "Everton", ScoreHome = 0, ScoreAway = 1, TeamAway = "Tottenham" },
                new Match { TeamHome = "Hull City", ScoreHome = 0, ScoreAway = 0, TeamAway = "Manchester Utd" },
                new Match { TeamHome = "Leicester City", ScoreHome = 5, ScoreAway = 1, TeamAway = "QPR" },
                new Match { TeamHome = "Manchester City", ScoreHome = 2, ScoreAway = 0, TeamAway = "Southampton" },
                new Match { TeamHome = "Newcastle", ScoreHome = 2, ScoreAway = 0, TeamAway = "West Ham" },
                new Match { TeamHome = "Stoke City", ScoreHome = 6, ScoreAway = 1, TeamAway = "Liverpool" },
            });
        }
    }
}