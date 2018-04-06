using Scoreboard.Model.Interfaces;
using Scoreboard.View;

namespace Scoreboard.Presenter
{
    public class ScoreBoardPresenter
    {
        private readonly IScoreBoardView scoreBoardView;
        private readonly IScoreBoardRepository scoreBoardRepository;
        public ScoreBoardPresenter(IScoreBoardView scoreBoardView, IScoreBoardRepository scoreBoardRepository)
        {
            this.scoreBoardView = scoreBoardView;
            this.scoreBoardRepository = scoreBoardRepository;
            this.scoreBoardView.ScoreBoardPresenter = this;
            this.scoreBoardView.ShowScoreboard();
        }
        public void UpdateScoreBoard()
        {
            scoreBoardView.MatchInfo = scoreBoardRepository.GetMatchDetails();
            scoreBoardView.ChallengerAInfo = scoreBoardRepository.GetChallenger(true);
            scoreBoardView.ChallengerBInfo = scoreBoardRepository.GetChallenger(false);
        }
    }
}
