using System;
using System.Windows.Forms;
using Scoreboard.Model.Mediator;

namespace Scoreboard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var concreteMediator = new ConcreteMediator();


            var mainMenuRepository = new Model.MainMenuRepository(concreteMediator);
            var scoreBoardRepository = new Model.ScoreBoardRepository(concreteMediator);

            var mainMenuView = new View.MainMenu();
            var scoreboardView = new View.Scoreboard();

            // TODO: IOC
            var mainMenuPresenter = new Presenter.MainMenuPresenter(mainMenuView, mainMenuRepository);
            var scoreBoardPresenter = new Presenter.ScoreBoardPresenter(scoreboardView, scoreBoardRepository);

            concreteMediator.Colleague1 = mainMenuRepository;
            concreteMediator.Colleague2 = scoreBoardRepository;

            Application.Run(mainMenuView);
        }
    }
}
