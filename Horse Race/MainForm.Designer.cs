namespace Horse_Race
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RaceBtn = new System.Windows.Forms.Button();
            this.JacRadioBtn = new System.Windows.Forms.RadioButton();
            this.MelRadioBtn = new System.Windows.Forms.RadioButton();
            this.MarRadioBtn = new System.Windows.Forms.RadioButton();
            this.JacTxtBox = new System.Windows.Forms.TextBox();
            this.MarTxtBox = new System.Windows.Forms.TextBox();
            this.MelTxtBox = new System.Windows.Forms.TextBox();
            this.BetMoneyNumBox = new System.Windows.Forms.NumericUpDown();
            this.BetHorseNumBox = new System.Windows.Forms.NumericUpDown();
            this.PunterMoneyLbl = new System.Windows.Forms.Label();
            this.PunterHorseLbl = new System.Windows.Forms.Label();
            this.DollarLbl = new System.Windows.Forms.Label();
            this.NumLbl = new System.Windows.Forms.Label();
            this.MaxBetTxtBox = new System.Windows.Forms.TextBox();
            this.BetBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.RaceResultTxtBox = new System.Windows.Forms.TextBox();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.WispPic = new System.Windows.Forms.PictureBox();
            this.BlossomPic = new System.Windows.Forms.PictureBox();
            this.BlizzardPic = new System.Windows.Forms.PictureBox();
            this.PrincePic = new System.Windows.Forms.PictureBox();
            this.TrackHorseSpeed = new System.Windows.Forms.TrackBar();
            this.HorseSpeedLbl = new System.Windows.Forms.Label();
            this.Apple = new System.Windows.Forms.PictureBox();
            this.TrophyImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BetMoneyNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHorseNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WispPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlossomPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlizzardPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHorseSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrophyImg)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceBtn
            // 
            this.RaceBtn.Enabled = false;
            this.RaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceBtn.Location = new System.Drawing.Point(12, 539);
            this.RaceBtn.Name = "RaceBtn";
            this.RaceBtn.Size = new System.Drawing.Size(124, 73);
            this.RaceBtn.TabIndex = 0;
            this.RaceBtn.Text = "Race!";
            this.RaceBtn.UseVisualStyleBackColor = true;
            this.RaceBtn.Click += new System.EventHandler(this.RaceBtn_Click);
            // 
            // JacRadioBtn
            // 
            this.JacRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JacRadioBtn.Location = new System.Drawing.Point(333, 591);
            this.JacRadioBtn.Name = "JacRadioBtn";
            this.JacRadioBtn.Size = new System.Drawing.Size(110, 21);
            this.JacRadioBtn.TabIndex = 0;
            this.JacRadioBtn.TabStop = true;
            this.JacRadioBtn.Text = "Jack";
            this.JacRadioBtn.UseVisualStyleBackColor = true;
            this.JacRadioBtn.CheckedChanged += new System.EventHandler(this.JacRadioBtn_CheckedChanged);
            // 
            // MelRadioBtn
            // 
            this.MelRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MelRadioBtn.Location = new System.Drawing.Point(333, 631);
            this.MelRadioBtn.Name = "MelRadioBtn";
            this.MelRadioBtn.Size = new System.Drawing.Size(110, 21);
            this.MelRadioBtn.TabIndex = 15;
            this.MelRadioBtn.TabStop = true;
            this.MelRadioBtn.Text = "Melissa";
            this.MelRadioBtn.UseVisualStyleBackColor = true;
            this.MelRadioBtn.CheckedChanged += new System.EventHandler(this.MelRadioBtn_CheckedChanged);
            // 
            // MarRadioBtn
            // 
            this.MarRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarRadioBtn.Location = new System.Drawing.Point(333, 671);
            this.MarRadioBtn.Name = "MarRadioBtn";
            this.MarRadioBtn.Size = new System.Drawing.Size(110, 21);
            this.MarRadioBtn.TabIndex = 17;
            this.MarRadioBtn.TabStop = true;
            this.MarRadioBtn.Text = "Marina";
            this.MarRadioBtn.UseVisualStyleBackColor = true;
            this.MarRadioBtn.CheckedChanged += new System.EventHandler(this.MarRadioBtn_CheckedChanged);
            // 
            // JacTxtBox
            // 
            this.JacTxtBox.Location = new System.Drawing.Point(859, 590);
            this.JacTxtBox.Name = "JacTxtBox";
            this.JacTxtBox.ReadOnly = true;
            this.JacTxtBox.Size = new System.Drawing.Size(363, 22);
            this.JacTxtBox.TabIndex = 18;
            this.JacTxtBox.Text = "Jack place your bet";
            // 
            // MarTxtBox
            // 
            this.MarTxtBox.Location = new System.Drawing.Point(859, 669);
            this.MarTxtBox.Name = "MarTxtBox";
            this.MarTxtBox.ReadOnly = true;
            this.MarTxtBox.Size = new System.Drawing.Size(363, 22);
            this.MarTxtBox.TabIndex = 19;
            this.MarTxtBox.Text = "Marina place your bet";
            // 
            // MelTxtBox
            // 
            this.MelTxtBox.Location = new System.Drawing.Point(859, 629);
            this.MelTxtBox.Name = "MelTxtBox";
            this.MelTxtBox.ReadOnly = true;
            this.MelTxtBox.Size = new System.Drawing.Size(363, 22);
            this.MelTxtBox.TabIndex = 20;
            this.MelTxtBox.Text = "Melissa place your bet";
            // 
            // BetMoneyNumBox
            // 
            this.BetMoneyNumBox.Location = new System.Drawing.Point(674, 631);
            this.BetMoneyNumBox.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BetMoneyNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetMoneyNumBox.Name = "BetMoneyNumBox";
            this.BetMoneyNumBox.Size = new System.Drawing.Size(120, 22);
            this.BetMoneyNumBox.TabIndex = 21;
            this.BetMoneyNumBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BetHorseNumBox
            // 
            this.BetHorseNumBox.Location = new System.Drawing.Point(674, 670);
            this.BetHorseNumBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BetHorseNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetHorseNumBox.Name = "BetHorseNumBox";
            this.BetHorseNumBox.Size = new System.Drawing.Size(120, 22);
            this.BetHorseNumBox.TabIndex = 22;
            this.BetHorseNumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PunterMoneyLbl
            // 
            this.PunterMoneyLbl.AutoSize = true;
            this.PunterMoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunterMoneyLbl.Location = new System.Drawing.Point(552, 631);
            this.PunterMoneyLbl.Name = "PunterMoneyLbl";
            this.PunterMoneyLbl.Size = new System.Drawing.Size(73, 17);
            this.PunterMoneyLbl.TabIndex = 23;
            this.PunterMoneyLbl.Text = "Jack Bets:";
            this.PunterMoneyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PunterHorseLbl
            // 
            this.PunterHorseLbl.AutoSize = true;
            this.PunterHorseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunterHorseLbl.Location = new System.Drawing.Point(552, 671);
            this.PunterHorseLbl.Name = "PunterHorseLbl";
            this.PunterHorseLbl.Size = new System.Drawing.Size(70, 17);
            this.PunterHorseLbl.TabIndex = 24;
            this.PunterHorseLbl.Text = "on Horse:";
            this.PunterHorseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DollarLbl
            // 
            this.DollarLbl.AutoSize = true;
            this.DollarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarLbl.Location = new System.Drawing.Point(652, 633);
            this.DollarLbl.Name = "DollarLbl";
            this.DollarLbl.Size = new System.Drawing.Size(18, 20);
            this.DollarLbl.TabIndex = 25;
            this.DollarLbl.Text = "$";
            // 
            // NumLbl
            // 
            this.NumLbl.AutoSize = true;
            this.NumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLbl.Location = new System.Drawing.Point(652, 672);
            this.NumLbl.Name = "NumLbl";
            this.NumLbl.Size = new System.Drawing.Size(18, 20);
            this.NumLbl.TabIndex = 26;
            this.NumLbl.Text = "#";
            // 
            // MaxBetTxtBox
            // 
            this.MaxBetTxtBox.Location = new System.Drawing.Point(555, 590);
            this.MaxBetTxtBox.Name = "MaxBetTxtBox";
            this.MaxBetTxtBox.ReadOnly = true;
            this.MaxBetTxtBox.Size = new System.Drawing.Size(239, 22);
            this.MaxBetTxtBox.TabIndex = 27;
            this.MaxBetTxtBox.Text = "Max Bet is $";
            // 
            // BetBtn
            // 
            this.BetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetBtn.Location = new System.Drawing.Point(555, 715);
            this.BetBtn.Name = "BetBtn";
            this.BetBtn.Size = new System.Drawing.Size(242, 43);
            this.BetBtn.TabIndex = 28;
            this.BetBtn.Text = "Make Bet";
            this.BetBtn.UseVisualStyleBackColor = true;
            this.BetBtn.Click += new System.EventHandler(this.BetBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn.Location = new System.Drawing.Point(12, 622);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(124, 66);
            this.RestartBtn.TabIndex = 29;
            this.RestartBtn.Text = "Bet Again";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Visible = false;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // RaceResultTxtBox
            // 
            this.RaceResultTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceResultTxtBox.Location = new System.Drawing.Point(333, 539);
            this.RaceResultTxtBox.Name = "RaceResultTxtBox";
            this.RaceResultTxtBox.ReadOnly = true;
            this.RaceResultTxtBox.Size = new System.Drawing.Size(889, 30);
            this.RaceResultTxtBox.TabIndex = 31;
            this.RaceResultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RaceResultTxtBox.Visible = false;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(12, 622);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(124, 66);
            this.NewGameBtn.TabIndex = 32;
            this.NewGameBtn.Text = "New Game?";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Visible = false;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // WispPic
            // 
            this.WispPic.BackColor = System.Drawing.Color.Transparent;
            this.WispPic.Image = global::Horse_Race.MainResource.Wisp;
            this.WispPic.Location = new System.Drawing.Point(-27, 140);
            this.WispPic.Name = "WispPic";
            this.WispPic.Size = new System.Drawing.Size(182, 132);
            this.WispPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WispPic.TabIndex = 30;
            this.WispPic.TabStop = false;
            // 
            // BlossomPic
            // 
            this.BlossomPic.BackColor = System.Drawing.Color.Transparent;
            this.BlossomPic.Image = global::Horse_Race.MainResource.Blossom;
            this.BlossomPic.Location = new System.Drawing.Point(-27, 396);
            this.BlossomPic.Name = "BlossomPic";
            this.BlossomPic.Size = new System.Drawing.Size(182, 132);
            this.BlossomPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlossomPic.TabIndex = 4;
            this.BlossomPic.TabStop = false;
            // 
            // BlizzardPic
            // 
            this.BlizzardPic.BackColor = System.Drawing.Color.Transparent;
            this.BlizzardPic.Image = global::Horse_Race.MainResource.Blizzard;
            this.BlizzardPic.Location = new System.Drawing.Point(-27, 268);
            this.BlizzardPic.Name = "BlizzardPic";
            this.BlizzardPic.Size = new System.Drawing.Size(182, 132);
            this.BlizzardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlizzardPic.TabIndex = 3;
            this.BlizzardPic.TabStop = false;
            // 
            // PrincePic
            // 
            this.PrincePic.BackColor = System.Drawing.Color.Transparent;
            this.PrincePic.Image = global::Horse_Race.MainResource.Prince;
            this.PrincePic.Location = new System.Drawing.Point(-27, 12);
            this.PrincePic.Name = "PrincePic";
            this.PrincePic.Size = new System.Drawing.Size(182, 132);
            this.PrincePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PrincePic.TabIndex = 1;
            this.PrincePic.TabStop = false;
            // 
            // TrackHorseSpeed
            // 
            this.TrackHorseSpeed.Location = new System.Drawing.Point(155, 572);
            this.TrackHorseSpeed.Maximum = 8;
            this.TrackHorseSpeed.Name = "TrackHorseSpeed";
            this.TrackHorseSpeed.Size = new System.Drawing.Size(149, 56);
            this.TrackHorseSpeed.TabIndex = 34;
            this.TrackHorseSpeed.Value = 6;
            this.TrackHorseSpeed.Visible = false;
            // 
            // HorseSpeedLbl
            // 
            this.HorseSpeedLbl.AutoSize = true;
            this.HorseSpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorseSpeedLbl.Location = new System.Drawing.Point(186, 549);
            this.HorseSpeedLbl.Name = "HorseSpeedLbl";
            this.HorseSpeedLbl.Size = new System.Drawing.Size(95, 17);
            this.HorseSpeedLbl.TabIndex = 35;
            this.HorseSpeedLbl.Text = "Horse Speed:";
            this.HorseSpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HorseSpeedLbl.Visible = false;
            // 
            // Apple
            // 
            this.Apple.BackColor = System.Drawing.Color.Transparent;
            this.Apple.Image = global::Horse_Race.MainResource.Apple;
            this.Apple.Location = new System.Drawing.Point(211, 701);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(42, 43);
            this.Apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Apple.TabIndex = 37;
            this.Apple.TabStop = false;
            this.Apple.Visible = false;
            // 
            // TrophyImg
            // 
            this.TrophyImg.BackColor = System.Drawing.Color.Transparent;
            this.TrophyImg.Enabled = false;
            this.TrophyImg.Image = global::Horse_Race.MainResource.Trophy;
            this.TrophyImg.Location = new System.Drawing.Point(114, 606);
            this.TrophyImg.Name = "TrophyImg";
            this.TrophyImg.Size = new System.Drawing.Size(237, 246);
            this.TrophyImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrophyImg.TabIndex = 38;
            this.TrophyImg.TabStop = false;
            this.TrophyImg.Click += new System.EventHandler(this.TrophyImg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 841);
            this.Controls.Add(this.HorseSpeedLbl);
            this.Controls.Add(this.TrackHorseSpeed);
            this.Controls.Add(this.RaceResultTxtBox);
            this.Controls.Add(this.WispPic);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.BetBtn);
            this.Controls.Add(this.MaxBetTxtBox);
            this.Controls.Add(this.NumLbl);
            this.Controls.Add(this.DollarLbl);
            this.Controls.Add(this.PunterHorseLbl);
            this.Controls.Add(this.PunterMoneyLbl);
            this.Controls.Add(this.BetHorseNumBox);
            this.Controls.Add(this.BlossomPic);
            this.Controls.Add(this.BlizzardPic);
            this.Controls.Add(this.PrincePic);
            this.Controls.Add(this.BetMoneyNumBox);
            this.Controls.Add(this.MelTxtBox);
            this.Controls.Add(this.MarTxtBox);
            this.Controls.Add(this.JacTxtBox);
            this.Controls.Add(this.MarRadioBtn);
            this.Controls.Add(this.MelRadioBtn);
            this.Controls.Add(this.JacRadioBtn);
            this.Controls.Add(this.RaceBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.TrophyImg);
            this.Controls.Add(this.Apple);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Horse Race";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BetMoneyNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHorseNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WispPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlossomPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlizzardPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHorseSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrophyImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RaceBtn;
        private System.Windows.Forms.PictureBox PrincePic;
        private System.Windows.Forms.PictureBox BlizzardPic;
        private System.Windows.Forms.PictureBox BlossomPic;
        private System.Windows.Forms.RadioButton JacRadioBtn;
        private System.Windows.Forms.RadioButton MelRadioBtn;
        private System.Windows.Forms.RadioButton MarRadioBtn;
        private System.Windows.Forms.TextBox JacTxtBox;
        private System.Windows.Forms.TextBox MarTxtBox;
        private System.Windows.Forms.TextBox MelTxtBox;
        private System.Windows.Forms.NumericUpDown BetMoneyNumBox;
        private System.Windows.Forms.NumericUpDown BetHorseNumBox;
        private System.Windows.Forms.Label PunterMoneyLbl;
        private System.Windows.Forms.Label PunterHorseLbl;
        private System.Windows.Forms.Label DollarLbl;
        private System.Windows.Forms.Label NumLbl;
        private System.Windows.Forms.TextBox MaxBetTxtBox;
        private System.Windows.Forms.Button BetBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.PictureBox WispPic;
        private System.Windows.Forms.TextBox RaceResultTxtBox;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.TrackBar TrackHorseSpeed;
        private System.Windows.Forms.Label HorseSpeedLbl;
        private System.Windows.Forms.PictureBox Apple;
        private System.Windows.Forms.PictureBox TrophyImg;
    }
}

