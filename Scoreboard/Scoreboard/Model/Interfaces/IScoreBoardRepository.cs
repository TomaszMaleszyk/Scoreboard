using System;

namespace Scoreboard.Model.Interfaces
{
    public interface IScoreBoardRepository
    {
        void CreateChallenger(string name, string surname, string college,bool isFirst);
        void SetMatchDetails(TimeSpan time, string competitionCategory, string tournamentStage);
        void SetPoints(int points,bool isFirst);
        Challenger GetChallenger(bool isFirst);
        MatchDetails GetMatchDetails();
        string GetPoints(bool isFirst);
        bool GetVisibility();
    }
}
