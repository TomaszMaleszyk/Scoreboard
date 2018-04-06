using Scoreboard.Model.Interfaces;
using Scoreboard.View;

namespace Scoreboard.Presenter
{
    public class MainMenuPresenter
    {
        private readonly IMainMenuView mainMenuView;
        private readonly IMainMenuRepository mainMenuRepository;

        public MainMenuPresenter(IMainMenuView mainMenuView, IMainMenuRepository mainMenuRepository)
        {
            this.mainMenuView = mainMenuView;
            this.mainMenuView.MainMenuPresenter = this;
            this.mainMenuRepository = mainMenuRepository;
            SetDataToChoice();
        }
        public void CreateNewChallenger()
        {
            mainMenuRepository.CreateChallenger(mainMenuView.ChallengerAInfo, true);
            mainMenuRepository.CreateChallenger(mainMenuView.ChallengerBInfo, false);
        }
        public void SetMatchDetails()
        {
            mainMenuRepository.SetMatchDetails(mainMenuView.MatchInfo);
        }
        public void ShowScoreboard()
        {
            mainMenuRepository.SetScoreboardVisibility();
        }
        public void UpdateScoreboard()
        {
            mainMenuRepository.ScoreboardUpdateChallengerData();
            mainMenuRepository.ScoreboardUpdateMatchDetailsData();
        }
        public void SetDataToChoice()
        {
            mainMenuView.ComboboxTournamentStageBindingSource = mainMenuRepository.SetTournamentStateToChoice();
            mainMenuView.ComboboxCategoryBindingSource = mainMenuRepository.SetWeightCategoriesToChoice();
            mainMenuView.ComboboxColleagueBindingSource = mainMenuRepository.SetColleguesToChoice();
        }
    }
}
