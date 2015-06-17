using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public int ScoreHome { get; set; }
        public int ScoreAway { get; set; }
    }

    public class MatchesList : List<Match>
    {
        public MatchesList()
        {
            AddRange(new[] {
                new Match { Id = 1000, TeamHome = "Arsenal", ScoreHome = 4, ScoreAway = 1, TeamAway = "West Brom" },
                new Match { Id = 1001, TeamHome = "Aston Villa", ScoreHome = 0, ScoreAway = 1, TeamAway = "Burnley" },
                new Match { Id = 1002, TeamHome = "Chelsea", ScoreHome = 3, ScoreAway = 1, TeamAway = "Sunderland" },
                new Match { Id = 1003, TeamHome = "Crystal Palace", ScoreHome = 1, ScoreAway = 0, TeamAway = "Swansea City" },
                new Match { Id = 1004, TeamHome = "Everton", ScoreHome = 0, ScoreAway = 1, TeamAway = "Tottenham" },
                new Match { Id = 1005, TeamHome = "Hull City", ScoreHome = 0, ScoreAway = 0, TeamAway = "Manchester Utd" },
                new Match { Id = 1006, TeamHome = "Leicester City", ScoreHome = 5, ScoreAway = 1, TeamAway = "QPR" },
                new Match { Id = 1007, TeamHome = "Manchester City", ScoreHome = 2, ScoreAway = 0, TeamAway = "Southampton" },
                new Match { Id = 1008, TeamHome = "Newcastle", ScoreHome = 2, ScoreAway = 0, TeamAway = "West Ham" },
                new Match { Id = 1009, TeamHome = "Stoke City", ScoreHome = 6, ScoreAway = 1, TeamAway = "Liverpool" },
            });
        }
    }
}