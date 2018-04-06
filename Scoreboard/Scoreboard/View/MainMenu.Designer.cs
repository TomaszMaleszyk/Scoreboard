namespace Scoreboard.View
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_surnameChallegerA = new System.Windows.Forms.Label();
            this.ądTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_points = new System.Windows.Forms.GroupBox();
            this.gb_challengerBpoints = new System.Windows.Forms.GroupBox();
            this.label_challengerBInfoColleague = new System.Windows.Forms.Label();
            this.label_challengerBInfo = new System.Windows.Forms.Label();
            this.numericUD_pointsChallengerB = new System.Windows.Forms.NumericUpDown();
            this.gb_challengerApoints = new System.Windows.Forms.GroupBox();
            this.label_challengerAInfoColleague = new System.Windows.Forms.Label();
            this.label_challengerAInfo = new System.Windows.Forms.Label();
            this.numericUD_pointsChallengerA = new System.Windows.Forms.NumericUpDown();
            this.textBox_surnameChallegerA = new System.Windows.Forms.TextBox();
            this.button_clockStart = new System.Windows.Forms.Button();
            this.gb_clockManager = new System.Windows.Forms.GroupBox();
            this.checkBox_clockPause = new System.Windows.Forms.CheckBox();
            this.button_resetScoreboard = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_clearData = new System.Windows.Forms.ToolStripMenuItem();
            this.label_colleagueChallegerA = new System.Windows.Forms.Label();
            this.numericUD_minutes = new System.Windows.Forms.NumericUpDown();
            this.numericUD_seconds = new System.Windows.Forms.NumericUpDown();
            this.comboBox_stage = new System.Windows.Forms.ComboBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_stage = new System.Windows.Forms.Label();
            this.gb_challengerBdata = new System.Windows.Forms.GroupBox();
            this.label_surnameChallegerB = new System.Windows.Forms.Label();
            this.textBox_surnameChallegerB = new System.Windows.Forms.TextBox();
            this.label_colleagueChallegerB = new System.Windows.Forms.Label();
            this.label_nameChallegerB = new System.Windows.Forms.Label();
            this.comboBox_colleagueChallengerB = new System.Windows.Forms.ComboBox();
            this.textBox_nameChallegerB = new System.Windows.Forms.TextBox();
            this.gb_challengerAdata = new System.Windows.Forms.GroupBox();
            this.button_clearSurnameATextBox = new System.Windows.Forms.Button();
            this.button_clearNameATextBox = new System.Windows.Forms.Button();
            this.label_nameChallegerA = new System.Windows.Forms.Label();
            this.comboBox_colleagueChallengerA = new System.Windows.Forms.ComboBox();
            this.textBox_nameChallegerA = new System.Windows.Forms.TextBox();
            this.gb_challengersData = new System.Windows.Forms.GroupBox();
            this.gb_matchSettings = new System.Windows.Forms.GroupBox();
            this.button_refreshScoreboard = new System.Windows.Forms.Button();
            this.gb_points.SuspendLayout();
            this.gb_challengerBpoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_pointsChallengerB)).BeginInit();
            this.gb_challengerApoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_pointsChallengerA)).BeginInit();
            this.gb_clockManager.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_seconds)).BeginInit();
            this.gb_challengerBdata.SuspendLayout();
            this.gb_challengerAdata.SuspendLayout();
            this.gb_challengersData.SuspendLayout();
            this.gb_matchSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_surnameChallegerA
            // 
            this.label_surnameChallegerA.AutoSize = true;
            this.label_surnameChallegerA.Location = new System.Drawing.Point(5, 59);
            this.label_surnameChallegerA.Name = "label_surnameChallegerA";
            this.label_surnameChallegerA.Size = new System.Drawing.Size(71, 17);
            this.label_surnameChallegerA.TabIndex = 38;
            this.label_surnameChallegerA.Text = "Nazwisko:";
            // 
            // ądTablicyToolStripMenuItem
            // 
            this.ądTablicyToolStripMenuItem.Checked = true;
            this.ądTablicyToolStripMenuItem.CheckOnClick = true;
            this.ądTablicyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ądTablicyToolStripMenuItem.Name = "ądTablicyToolStripMenuItem";
            this.ądTablicyToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.ądTablicyToolStripMenuItem.Text = "Podglad tablicy";
            // 
            // gb_points
            // 
            this.gb_points.Controls.Add(this.gb_challengerBpoints);
            this.gb_points.Controls.Add(this.gb_challengerApoints);
            this.gb_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.gb_points.Location = new System.Drawing.Point(12, 256);
            this.gb_points.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_points.Name = "gb_points";
            this.gb_points.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_points.Size = new System.Drawing.Size(535, 162);
            this.gb_points.TabIndex = 58;
            this.gb_points.TabStop = false;
            this.gb_points.Text = "Punktacja";
            // 
            // gb_challengerBpoints
            // 
            this.gb_challengerBpoints.Controls.Add(this.label_challengerBInfoColleague);
            this.gb_challengerBpoints.Controls.Add(this.label_challengerBInfo);
            this.gb_challengerBpoints.Controls.Add(this.numericUD_pointsChallengerB);
            this.gb_challengerBpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.gb_challengerBpoints.Location = new System.Drawing.Point(275, 21);
            this.gb_challengerBpoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerBpoints.Name = "gb_challengerBpoints";
            this.gb_challengerBpoints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerBpoints.Size = new System.Drawing.Size(243, 132);
            this.gb_challengerBpoints.TabIndex = 50;
            this.gb_challengerBpoints.TabStop = false;
            this.gb_challengerBpoints.Text = "Zawodnik B";
            // 
            // label_challengerBInfoColleague
            // 
            this.label_challengerBInfoColleague.AutoSize = true;
            this.label_challengerBInfoColleague.Location = new System.Drawing.Point(9, 62);
            this.label_challengerBInfoColleague.Name = "label_challengerBInfoColleague";
            this.label_challengerBInfoColleague.Size = new System.Drawing.Size(126, 17);
            this.label_challengerBInfoColleague.TabIndex = 37;
            this.label_challengerBInfoColleague.Text = "Zawodnik Uczelnia";
            // 
            // label_challengerBInfo
            // 
            this.label_challengerBInfo.AutoSize = true;
            this.label_challengerBInfo.Location = new System.Drawing.Point(9, 30);
            this.label_challengerBInfo.Name = "label_challengerBInfo";
            this.label_challengerBInfo.Size = new System.Drawing.Size(160, 17);
            this.label_challengerBInfo.TabIndex = 36;
            this.label_challengerBInfo.Text = "Zawodnik Imie Nazwisko";
            // 
            // numericUD_pointsChallengerB
            // 
            this.numericUD_pointsChallengerB.Location = new System.Drawing.Point(12, 91);
            this.numericUD_pointsChallengerB.Margin = new System.Windows.Forms.Padding(4);
            this.numericUD_pointsChallengerB.Name = "numericUD_pointsChallengerB";
            this.numericUD_pointsChallengerB.ReadOnly = true;
            this.numericUD_pointsChallengerB.Size = new System.Drawing.Size(160, 22);
            this.numericUD_pointsChallengerB.TabIndex = 35;
            // 
            // gb_challengerApoints
            // 
            this.gb_challengerApoints.Controls.Add(this.label_challengerAInfoColleague);
            this.gb_challengerApoints.Controls.Add(this.label_challengerAInfo);
            this.gb_challengerApoints.Controls.Add(this.numericUD_pointsChallengerA);
            this.gb_challengerApoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.gb_challengerApoints.Location = new System.Drawing.Point(5, 21);
            this.gb_challengerApoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerApoints.Name = "gb_challengerApoints";
            this.gb_challengerApoints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerApoints.Size = new System.Drawing.Size(243, 132);
            this.gb_challengerApoints.TabIndex = 49;
            this.gb_challengerApoints.TabStop = false;
            this.gb_challengerApoints.Text = "Zawodnik A";
            // 
            // label_challengerAInfoColleague
            // 
            this.label_challengerAInfoColleague.AutoSize = true;
            this.label_challengerAInfoColleague.Location = new System.Drawing.Point(9, 62);
            this.label_challengerAInfoColleague.Name = "label_challengerAInfoColleague";
            this.label_challengerAInfoColleague.Size = new System.Drawing.Size(126, 17);
            this.label_challengerAInfoColleague.TabIndex = 37;
            this.label_challengerAInfoColleague.Text = "Zawodnik Uczelnia";
            // 
            // label_challengerAInfo
            // 
            this.label_challengerAInfo.AutoSize = true;
            this.label_challengerAInfo.Location = new System.Drawing.Point(9, 30);
            this.label_challengerAInfo.Name = "label_challengerAInfo";
            this.label_challengerAInfo.Size = new System.Drawing.Size(160, 17);
            this.label_challengerAInfo.TabIndex = 36;
            this.label_challengerAInfo.Text = "Zawodnik Imie Nazwisko";
            // 
            // numericUD_pointsChallengerA
            // 
            this.numericUD_pointsChallengerA.Location = new System.Drawing.Point(12, 91);
            this.numericUD_pointsChallengerA.Margin = new System.Windows.Forms.Padding(4);
            this.numericUD_pointsChallengerA.Name = "numericUD_pointsChallengerA";
            this.numericUD_pointsChallengerA.ReadOnly = true;
            this.numericUD_pointsChallengerA.Size = new System.Drawing.Size(160, 22);
            this.numericUD_pointsChallengerA.TabIndex = 35;
            // 
            // textBox_surnameChallegerA
            // 
            this.textBox_surnameChallegerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_surnameChallegerA.Location = new System.Drawing.Point(84, 59);
            this.textBox_surnameChallegerA.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_surnameChallegerA.Name = "textBox_surnameChallegerA";
            this.textBox_surnameChallegerA.Size = new System.Drawing.Size(132, 23);
            this.textBox_surnameChallegerA.TabIndex = 37;
            // 
            // button_clockStart
            // 
            this.button_clockStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_clockStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clockStart.Location = new System.Drawing.Point(20, 39);
            this.button_clockStart.Margin = new System.Windows.Forms.Padding(4);
            this.button_clockStart.Name = "button_clockStart";
            this.button_clockStart.Size = new System.Drawing.Size(112, 28);
            this.button_clockStart.TabIndex = 48;
            this.button_clockStart.Text = "START";
            this.button_clockStart.UseVisualStyleBackColor = false;
            // 
            // gb_clockManager
            // 
            this.gb_clockManager.Controls.Add(this.checkBox_clockPause);
            this.gb_clockManager.Controls.Add(this.button_clockStart);
            this.gb_clockManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb_clockManager.Location = new System.Drawing.Point(552, 256);
            this.gb_clockManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_clockManager.Name = "gb_clockManager";
            this.gb_clockManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_clockManager.Size = new System.Drawing.Size(155, 162);
            this.gb_clockManager.TabIndex = 59;
            this.gb_clockManager.TabStop = false;
            this.gb_clockManager.Text = "Zarządzanie zegarem";
            // 
            // checkBox_clockPause
            // 
            this.checkBox_clockPause.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_clockPause.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox_clockPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_clockPause.Location = new System.Drawing.Point(21, 74);
            this.checkBox_clockPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_clockPause.Name = "checkBox_clockPause";
            this.checkBox_clockPause.Size = new System.Drawing.Size(113, 79);
            this.checkBox_clockPause.TabIndex = 53;
            this.checkBox_clockPause.Text = "Pauza";
            this.checkBox_clockPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_clockPause.UseVisualStyleBackColor = false;
            // 
            // button_resetScoreboard
            // 
            this.button_resetScoreboard.Location = new System.Drawing.Point(552, 424);
            this.button_resetScoreboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_resetScoreboard.Name = "button_resetScoreboard";
            this.button_resetScoreboard.Size = new System.Drawing.Size(155, 59);
            this.button_resetScoreboard.TabIndex = 60;
            this.button_resetScoreboard.Text = "Resetuj tablice";
            this.button_resetScoreboard.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(744, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ądTablicyToolStripMenuItem,
            this.ToolStripMenuItem_clearData});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ToolStripMenuItem_clearData
            // 
            this.ToolStripMenuItem_clearData.Name = "ToolStripMenuItem_clearData";
            this.ToolStripMenuItem_clearData.Size = new System.Drawing.Size(187, 26);
            this.ToolStripMenuItem_clearData.Text = "Czysc dane";
            // 
            // label_colleagueChallegerA
            // 
            this.label_colleagueChallegerA.AutoSize = true;
            this.label_colleagueChallegerA.Location = new System.Drawing.Point(5, 91);
            this.label_colleagueChallegerA.Name = "label_colleagueChallegerA";
            this.label_colleagueChallegerA.Size = new System.Drawing.Size(66, 17);
            this.label_colleagueChallegerA.TabIndex = 36;
            this.label_colleagueChallegerA.Text = "Uczelnia:";
            // 
            // numericUD_minutes
            // 
            this.numericUD_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numericUD_minutes.Location = new System.Drawing.Point(16, 135);
            this.numericUD_minutes.Margin = new System.Windows.Forms.Padding(4);
            this.numericUD_minutes.Name = "numericUD_minutes";
            this.numericUD_minutes.Size = new System.Drawing.Size(49, 23);
            this.numericUD_minutes.TabIndex = 55;
            // 
            // numericUD_seconds
            // 
            this.numericUD_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numericUD_seconds.Location = new System.Drawing.Point(83, 135);
            this.numericUD_seconds.Margin = new System.Windows.Forms.Padding(4);
            this.numericUD_seconds.Name = "numericUD_seconds";
            this.numericUD_seconds.Size = new System.Drawing.Size(49, 23);
            this.numericUD_seconds.TabIndex = 54;
            // 
            // comboBox_stage
            // 
            this.comboBox_stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_stage.FormattingEnabled = true;
            this.comboBox_stage.Location = new System.Drawing.Point(16, 85);
            this.comboBox_stage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_stage.Name = "comboBox_stage";
            this.comboBox_stage.Size = new System.Drawing.Size(119, 24);
            this.comboBox_stage.TabIndex = 43;
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(16, 38);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(116, 24);
            this.comboBox_category.TabIndex = 42;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label_category.Location = new System.Drawing.Point(13, 18);
            this.label_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(107, 17);
            this.label_category.TabIndex = 31;
            this.label_category.Text = "Kategoria: (KG)";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label_time.Location = new System.Drawing.Point(19, 112);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(43, 17);
            this.label_time.TabIndex = 40;
            this.label_time.Text = "Czas:";
            // 
            // label_stage
            // 
            this.label_stage.AutoSize = true;
            this.label_stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label_stage.Location = new System.Drawing.Point(13, 65);
            this.label_stage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_stage.Name = "label_stage";
            this.label_stage.Size = new System.Drawing.Size(41, 17);
            this.label_stage.TabIndex = 38;
            this.label_stage.Text = "Etap:";
            // 
            // gb_challengerBdata
            // 
            this.gb_challengerBdata.Controls.Add(this.label_surnameChallegerB);
            this.gb_challengerBdata.Controls.Add(this.textBox_surnameChallegerB);
            this.gb_challengerBdata.Controls.Add(this.label_colleagueChallegerB);
            this.gb_challengerBdata.Controls.Add(this.label_nameChallegerB);
            this.gb_challengerBdata.Controls.Add(this.comboBox_colleagueChallengerB);
            this.gb_challengerBdata.Controls.Add(this.textBox_nameChallegerB);
            this.gb_challengerBdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.gb_challengerBdata.Location = new System.Drawing.Point(275, 22);
            this.gb_challengerBdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerBdata.Name = "gb_challengerBdata";
            this.gb_challengerBdata.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerBdata.Size = new System.Drawing.Size(243, 132);
            this.gb_challengerBdata.TabIndex = 47;
            this.gb_challengerBdata.TabStop = false;
            this.gb_challengerBdata.Text = "Zawodnik B";
            // 
            // label_surnameChallegerB
            // 
            this.label_surnameChallegerB.AutoSize = true;
            this.label_surnameChallegerB.Location = new System.Drawing.Point(5, 59);
            this.label_surnameChallegerB.Name = "label_surnameChallegerB";
            this.label_surnameChallegerB.Size = new System.Drawing.Size(71, 17);
            this.label_surnameChallegerB.TabIndex = 38;
            this.label_surnameChallegerB.Text = "Nazwisko:";
            // 
            // textBox_surnameChallegerB
            // 
            this.textBox_surnameChallegerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_surnameChallegerB.Location = new System.Drawing.Point(84, 59);
            this.textBox_surnameChallegerB.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_surnameChallegerB.Name = "textBox_surnameChallegerB";
            this.textBox_surnameChallegerB.Size = new System.Drawing.Size(132, 23);
            this.textBox_surnameChallegerB.TabIndex = 37;
            // 
            // label_colleagueChallegerB
            // 
            this.label_colleagueChallegerB.AutoSize = true;
            this.label_colleagueChallegerB.Location = new System.Drawing.Point(5, 91);
            this.label_colleagueChallegerB.Name = "label_colleagueChallegerB";
            this.label_colleagueChallegerB.Size = new System.Drawing.Size(66, 17);
            this.label_colleagueChallegerB.TabIndex = 36;
            this.label_colleagueChallegerB.Text = "Uczelnia:";
            // 
            // label_nameChallegerB
            // 
            this.label_nameChallegerB.AutoSize = true;
            this.label_nameChallegerB.Location = new System.Drawing.Point(5, 28);
            this.label_nameChallegerB.Name = "label_nameChallegerB";
            this.label_nameChallegerB.Size = new System.Drawing.Size(37, 17);
            this.label_nameChallegerB.TabIndex = 35;
            this.label_nameChallegerB.Text = "Imie:";
            // 
            // comboBox_colleagueChallengerB
            // 
            this.comboBox_colleagueChallengerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_colleagueChallengerB.FormattingEnabled = true;
            this.comboBox_colleagueChallengerB.Location = new System.Drawing.Point(84, 91);
            this.comboBox_colleagueChallengerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_colleagueChallengerB.Name = "comboBox_colleagueChallengerB";
            this.comboBox_colleagueChallengerB.Size = new System.Drawing.Size(132, 24);
            this.comboBox_colleagueChallengerB.TabIndex = 23;
            // 
            // textBox_nameChallegerB
            // 
            this.textBox_nameChallegerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_nameChallegerB.Location = new System.Drawing.Point(84, 28);
            this.textBox_nameChallegerB.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nameChallegerB.Name = "textBox_nameChallegerB";
            this.textBox_nameChallegerB.Size = new System.Drawing.Size(132, 23);
            this.textBox_nameChallegerB.TabIndex = 22;
            // 
            // gb_challengerAdata
            // 
            this.gb_challengerAdata.Controls.Add(this.button_clearSurnameATextBox);
            this.gb_challengerAdata.Controls.Add(this.button_clearNameATextBox);
            this.gb_challengerAdata.Controls.Add(this.label_surnameChallegerA);
            this.gb_challengerAdata.Controls.Add(this.textBox_surnameChallegerA);
            this.gb_challengerAdata.Controls.Add(this.label_colleagueChallegerA);
            this.gb_challengerAdata.Controls.Add(this.label_nameChallegerA);
            this.gb_challengerAdata.Controls.Add(this.comboBox_colleagueChallengerA);
            this.gb_challengerAdata.Controls.Add(this.textBox_nameChallegerA);
            this.gb_challengerAdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.gb_challengerAdata.Location = new System.Drawing.Point(9, 22);
            this.gb_challengerAdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerAdata.Name = "gb_challengerAdata";
            this.gb_challengerAdata.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengerAdata.Size = new System.Drawing.Size(243, 132);
            this.gb_challengerAdata.TabIndex = 46;
            this.gb_challengerAdata.TabStop = false;
            this.gb_challengerAdata.Text = "Zawodnik A";
            // 
            // button_clearSurnameATextBox
            // 
            this.button_clearSurnameATextBox.Location = new System.Drawing.Point(219, 59);
            this.button_clearSurnameATextBox.Name = "button_clearSurnameATextBox";
            this.button_clearSurnameATextBox.Size = new System.Drawing.Size(24, 23);
            this.button_clearSurnameATextBox.TabIndex = 49;
            this.button_clearSurnameATextBox.Text = "X";
            this.button_clearSurnameATextBox.UseVisualStyleBackColor = true;
            // 
            // button_clearNameATextBox
            // 
            this.button_clearNameATextBox.Location = new System.Drawing.Point(219, 28);
            this.button_clearNameATextBox.Name = "button_clearNameATextBox";
            this.button_clearNameATextBox.Size = new System.Drawing.Size(24, 23);
            this.button_clearNameATextBox.TabIndex = 48;
            this.button_clearNameATextBox.Text = "X";
            this.button_clearNameATextBox.UseVisualStyleBackColor = true;
            // 
            // label_nameChallegerA
            // 
            this.label_nameChallegerA.AutoSize = true;
            this.label_nameChallegerA.Location = new System.Drawing.Point(5, 28);
            this.label_nameChallegerA.Name = "label_nameChallegerA";
            this.label_nameChallegerA.Size = new System.Drawing.Size(37, 17);
            this.label_nameChallegerA.TabIndex = 35;
            this.label_nameChallegerA.Text = "Imie:";
            // 
            // comboBox_colleagueChallengerA
            // 
            this.comboBox_colleagueChallengerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_colleagueChallengerA.FormattingEnabled = true;
            this.comboBox_colleagueChallengerA.Location = new System.Drawing.Point(84, 91);
            this.comboBox_colleagueChallengerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_colleagueChallengerA.Name = "comboBox_colleagueChallengerA";
            this.comboBox_colleagueChallengerA.Size = new System.Drawing.Size(132, 24);
            this.comboBox_colleagueChallengerA.TabIndex = 23;
            // 
            // textBox_nameChallegerA
            // 
            this.textBox_nameChallegerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox_nameChallegerA.Location = new System.Drawing.Point(84, 28);
            this.textBox_nameChallegerA.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nameChallegerA.Name = "textBox_nameChallegerA";
            this.textBox_nameChallegerA.Size = new System.Drawing.Size(132, 23);
            this.textBox_nameChallegerA.TabIndex = 22;
            // 
            // gb_challengersData
            // 
            this.gb_challengersData.Controls.Add(this.gb_challengerBdata);
            this.gb_challengersData.Controls.Add(this.gb_challengerAdata);
            this.gb_challengersData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.gb_challengersData.Location = new System.Drawing.Point(12, 30);
            this.gb_challengersData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengersData.Name = "gb_challengersData";
            this.gb_challengersData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_challengersData.Size = new System.Drawing.Size(535, 165);
            this.gb_challengersData.TabIndex = 57;
            this.gb_challengersData.TabStop = false;
            this.gb_challengersData.Text = "Dane zawodników";
            // 
            // gb_matchSettings
            // 
            this.gb_matchSettings.Controls.Add(this.numericUD_minutes);
            this.gb_matchSettings.Controls.Add(this.numericUD_seconds);
            this.gb_matchSettings.Controls.Add(this.comboBox_stage);
            this.gb_matchSettings.Controls.Add(this.comboBox_category);
            this.gb_matchSettings.Controls.Add(this.label_category);
            this.gb_matchSettings.Controls.Add(this.label_time);
            this.gb_matchSettings.Controls.Add(this.label_stage);
            this.gb_matchSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.gb_matchSettings.Location = new System.Drawing.Point(552, 30);
            this.gb_matchSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_matchSettings.Name = "gb_matchSettings";
            this.gb_matchSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_matchSettings.Size = new System.Drawing.Size(155, 165);
            this.gb_matchSettings.TabIndex = 56;
            this.gb_matchSettings.TabStop = false;
            this.gb_matchSettings.Text = "Ustawienia meczu";
            // 
            // button_refreshScoreboard
            // 
            this.button_refreshScoreboard.Location = new System.Drawing.Point(32, 203);
            this.button_refreshScoreboard.Margin = new System.Windows.Forms.Padding(4);
            this.button_refreshScoreboard.Name = "button_refreshScoreboard";
            this.button_refreshScoreboard.Size = new System.Drawing.Size(653, 46);
            this.button_refreshScoreboard.TabIndex = 55;
            this.button_refreshScoreboard.Text = "Refresh scoreboard";
            this.button_refreshScoreboard.UseVisualStyleBackColor = true;
            this.button_refreshScoreboard.Click += new System.EventHandler(this.button_refreshScoreboard_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 520);
            this.Controls.Add(this.gb_points);
            this.Controls.Add(this.gb_clockManager);
            this.Controls.Add(this.button_resetScoreboard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gb_challengersData);
            this.Controls.Add(this.gb_matchSettings);
            this.Controls.Add(this.button_refreshScoreboard);
            this.Name = "MainMenu";
            this.gb_points.ResumeLayout(false);
            this.gb_challengerBpoints.ResumeLayout(false);
            this.gb_challengerBpoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_pointsChallengerB)).EndInit();
            this.gb_challengerApoints.ResumeLayout(false);
            this.gb_challengerApoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_pointsChallengerA)).EndInit();
            this.gb_clockManager.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_seconds)).EndInit();
            this.gb_challengerBdata.ResumeLayout(false);
            this.gb_challengerBdata.PerformLayout();
            this.gb_challengerAdata.ResumeLayout(false);
            this.gb_challengerAdata.PerformLayout();
            this.gb_challengersData.ResumeLayout(false);
            this.gb_matchSettings.ResumeLayout(false);
            this.gb_matchSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_surnameChallegerA;
        private System.Windows.Forms.ToolStripMenuItem ądTablicyToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_points;
        private System.Windows.Forms.GroupBox gb_challengerBpoints;
        private System.Windows.Forms.Label label_challengerBInfoColleague;
        private System.Windows.Forms.Label label_challengerBInfo;
        private System.Windows.Forms.NumericUpDown numericUD_pointsChallengerB;
        private System.Windows.Forms.GroupBox gb_challengerApoints;
        private System.Windows.Forms.Label label_challengerAInfoColleague;
        private System.Windows.Forms.Label label_challengerAInfo;
        private System.Windows.Forms.NumericUpDown numericUD_pointsChallengerA;
        private System.Windows.Forms.TextBox textBox_surnameChallegerA;
        private System.Windows.Forms.Button button_clockStart;
        private System.Windows.Forms.GroupBox gb_clockManager;
        private System.Windows.Forms.CheckBox checkBox_clockPause;
        private System.Windows.Forms.Button button_resetScoreboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_clearData;
        private System.Windows.Forms.Label label_colleagueChallegerA;
        private System.Windows.Forms.NumericUpDown numericUD_minutes;
        private System.Windows.Forms.NumericUpDown numericUD_seconds;
        private System.Windows.Forms.ComboBox comboBox_stage;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_stage;
        private System.Windows.Forms.GroupBox gb_challengerBdata;
        private System.Windows.Forms.Label label_surnameChallegerB;
        private System.Windows.Forms.TextBox textBox_surnameChallegerB;
        private System.Windows.Forms.Label label_colleagueChallegerB;
        private System.Windows.Forms.Label label_nameChallegerB;
        private System.Windows.Forms.ComboBox comboBox_colleagueChallengerB;
        private System.Windows.Forms.TextBox textBox_nameChallegerB;
        private System.Windows.Forms.GroupBox gb_challengerAdata;
        private System.Windows.Forms.Label label_nameChallegerA;
        private System.Windows.Forms.ComboBox comboBox_colleagueChallengerA;
        private System.Windows.Forms.TextBox textBox_nameChallegerA;
        private System.Windows.Forms.GroupBox gb_challengersData;
        private System.Windows.Forms.GroupBox gb_matchSettings;
        private System.Windows.Forms.Button button_refreshScoreboard;
        private System.Windows.Forms.Button button_clearNameATextBox;
        private System.Windows.Forms.Button button_clearSurnameATextBox;
    }
}