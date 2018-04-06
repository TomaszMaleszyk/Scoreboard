using Scoreboard.Presenter;

namespace Scoreboard.View
{
    public interface IScoreBoardView : IView
    {
        ScoreBoardPresenter ScoreBoardPresenter { set; }
        bool Visibility { set; }
        void ShowScoreboard();
    }
}
