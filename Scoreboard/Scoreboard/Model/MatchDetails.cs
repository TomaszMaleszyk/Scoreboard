using System;

namespace Scoreboard.Model
{
    public class MatchDetails
    {
        public TimeSpan Time;
        public string CompetitionCategory;
        public string TournamentStage;
        public MatchDetails(TimeSpan time, string competitionCategory, string tournamentStage)
        {
            Time = time;
            CompetitionCategory = competitionCategory;
            TournamentStage = tournamentStage;
        }
    }
}
