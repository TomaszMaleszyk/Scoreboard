using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Scoreboard.Model;
using Scoreboard.Presenter;

namespace Scoreboard.View
{
    public partial class MainMenu : Form, IMainMenuView
    {
        public MainMenuPresenter MainMenuPresenter { private get; set; }
        public MatchDetails MatchInfo
        {
            get
            {
                return new MatchDetails(new TimeSpan(0, 0, int.Parse(numericUD_minutes.Text), int.Parse(numericUD_seconds.Text)),
                    comboBox_category.SelectedText,
                    comboBox_stage.SelectedText);
            }
            set
            {
                numericUD_minutes.Text = value.Time.ToString(); //tutaj poprawić
                comboBox_category.Text = value.CompetitionCategory;
                comboBox_stage.Text = value.TournamentStage;
            }

        }
        public Challenger ChallengerAInfo
        {
            get
            {
                return new Challenger(textBox_nameChallegerA.Text, textBox_surnameChallegerA.Text,
                                      comboBox_colleagueChallengerA.SelectedItem.ToString());
            }
            set
            {
                textBox_nameChallegerA.Text = value.Name;
                textBox_surnameChallegerA.Text = value.Surname;
                comboBox_colleagueChallengerA.SelectedText = value.College;
            }
        }
        public Challenger ChallengerBInfo
        {
            get
            {
                return new Challenger(textBox_nameChallegerB.Text, textBox_surnameChallegerB.Text,
                    comboBox_colleagueChallengerB.SelectedItem.ToString());
            }
            set
            {
                textBox_nameChallegerB.Text = value.Name;
                textBox_surnameChallegerB.Text = value.Surname;
                comboBox_colleagueChallengerB.SelectedText = value.College;
            }
        }
        public List<string> ComboboxTournamentStageBindingSource
        {
            get
            {
                return (from object item in comboBox_stage.Items select item.ToString()).ToList();
            }
            set
            {
                SetComboboxDataSource(comboBox_stage, value);
            }
        }
        public List<string> ComboboxColleagueBindingSource
        {
            get
            {
                return (from object item in comboBox_colleagueChallengerA.Items select item.ToString()).ToList();
            }
            set
            {
                SetComboboxDataSource(comboBox_colleagueChallengerA, value);
                SetComboboxDataSource(comboBox_colleagueChallengerB, value);
            }
        }
     
        public List<string> ComboboxCategoryBindingSource
        {
            get
            {
                return (from object item in comboBox_category.Items select item.ToString()).ToList();
            }
            set
            {
                SetComboboxDataSource(comboBox_category, value);
            }
        }
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button_refreshScoreboard_Click(object sender, EventArgs e)
        {
            MainMenuPresenter.CreateNewChallenger();
            MainMenuPresenter.SetMatchDetails();
            MainMenuPresenter.UpdateScoreboard();
            //   MainMenuPresenter.ShowScoreboard();
        }
        private static void SetComboboxDataSource<T>(ComboBox comboBox, List<T> dataList)
        {
            comboBox.DataSource = dataList;
            comboBox.BindingContext = new BindingContext();
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
