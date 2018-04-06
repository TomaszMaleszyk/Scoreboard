using System.Collections.Generic;
using Scoreboard.Presenter;

namespace Scoreboard.View
{
    public interface IMainMenuView : IView
    {
        MainMenuPresenter MainMenuPresenter { set; }
        List<string> ComboboxTournamentStageBindingSource { get; set; }
        List<string> ComboboxColleagueBindingSource { get; set; }
        List<string> ComboboxCategoryBindingSource { get; set; }
    }
}
