using Scoreboard.Model;

namespace Scoreboard.View
{
    public interface IView
    {
        MatchDetails MatchInfo { get; set; }
        Challenger ChallengerAInfo { get; set; }
        Challenger ChallengerBInfo { get; set; }

        //string BattleTime { get; set; }
        //string TournamentStage { get; set; }
        //string CompetitionCategory { get; set; }
        //string ChallengerAName { get; set; }
        //string ChallengerASurname { get; set; }
        //string ChallengerACollege { get; set; }
        //decimal ChallengerAPoints { get; set; }
        //string ChallengerBName { get; set; }
        //string ChallengerBSurname { get; set; }
        //string ChallengerBCollege { get; set; }
        //decimal ChallengerBPoints { get; set; }
    }
}
