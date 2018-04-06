using System.Collections.Generic;

namespace Scoreboard.Model.Interfaces
{
    public interface IMainMenuRepository
    {
        void CreateChallenger(Challenger challenger, bool isFirst);
        void SetMatchDetails(MatchDetails matchInfo);
        void SetPoints(int points, bool isFirst);
        void SetScoreboardVisibility();
        void ScoreboardUpdateChallengerData();
        void ScoreboardUpdateMatchDetailsData();
        List<string> SetColleguesToChoice();
        List<string> SetTournamentStateToChoice();
        List<string> SetWeightCategoriesToChoice();
    }
}
