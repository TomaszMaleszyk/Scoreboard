using System;
using System.Drawing;
using System.Windows.Forms;
using Scoreboard.Model;

namespace Scoreboard.View
{
    public partial class Scoreboard : Form, IScoreBoardView
    {
        private const float LargerFontFactor = 1.497f;
        private const float SmallerFontFactor = 1.482f;
        public Presenter.ScoreBoardPresenter ScoreBoardPresenter
        { private get; set; }
        public MatchDetails MatchInfo
        {
            get
            {
                return new MatchDetails(new TimeSpan(0, 0, 0, 0),
                                    label_competitionCategory.Text,
                                    label_tournamentStage.Text);
            }
            set
            {
                label_mainClock.Text = $@"{value.Time.Minutes}:{value.Time.Seconds}";
                label_competitionCategory.Text = value.CompetitionCategory;
                label_tournamentStage.Text = value.TournamentStage;
            }
        }

        public Challenger ChallengerAInfo
        {
            get
            {
                return new Challenger(label_challengerAName.Text, label_challengerASurname.Text, label_challengerACollege.Text);
            }
            set
            {
                label_challengerAName.Text = value.Name;
                label_challengerASurname.Text = value.Surname;
                label_challengerACollege.Text = value.College;
            }
        }

        public Challenger ChallengerBInfo
        {
            get
            {
                return new Challenger(label_challengerBName.Text, label_challengerBSurname.Text, label_challengerBCollege.Text);
            }
            set
            {
                label_challengerBName.Text = value.Name;
                label_challengerBSurname.Text = value.Surname;
                label_challengerBCollege.Text = value.College;
            }
        }

        public bool Visibility { set { Visibility = value; } }
        #region Position change

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ScoreBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }
        #endregion
        #region Change window size
        private const int CGrip = 16;
        private const int CCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                var pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if(pos.Y < CCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if(pos.X >= ClientSize.Width - CGrip && pos.Y >= ClientSize.Height - CGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        private static int GetFormArea(Size size)
        {
            return size.Height * size.Width;
        }
        private void Scoreboard_Resize(object sender, EventArgs e)
        {
            var bigger = GetFormArea(Size) > lastFormSize;
            var scaleFactor = bigger ? LargerFontFactor : SmallerFontFactor;

            ResizeFont(Controls, scaleFactor);

            lastFormSize = GetFormArea(Size);
        }
        private static void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach(Control c in coll)
            {
                if(c.HasChildren)
                {
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {
                    c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor * 0.67f);
                }
            }
        }
        private int lastFormSize;
        public Scoreboard()
        {
            InitializeComponent();
            Resize += Scoreboard_Resize;
            lastFormSize = GetFormArea(Size);
        }
        private void Scoreboard_Load(object sender, EventArgs e)
        {
        }
        public void ShowScoreboard()
        {
            Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ScoreBoardPresenter.UpdateScoreBoard();
        }

    }
}
