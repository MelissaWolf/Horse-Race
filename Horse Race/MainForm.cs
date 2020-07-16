using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public partial class MainForm : Form
    {
        //Creating Horses
        Horse Prince;
        Horse Wisp;
        Horse Blizzard;
        Horse Blossom;

        Horse[] Horses = new Horse[4];

        //Creating Punters Array
        Punter[] Punters = new Punter[3];

        //Creating Apple
        Apple LuckyApple;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Defining Horses
            Horses[0] = (Prince = new Horse("Prince", 1, PrincePic));
            Horses[1] = (Wisp = new Horse("Wisp", 2, WispPic));
            Horses[2] = (Blizzard = new Horse("Blizzard", 3, BlizzardPic));
            Horses[3] = (Blossom = new Horse("Blossom", 4, BlossomPic));

            //Defining Punters
            Punters[0] = Factory.MakePunter("Jack", JacRadioBtn, JacTxtBox);
            Punters[1] = Factory.MakePunter("Melissa", MelRadioBtn, MelTxtBox);
            Punters[2] = Factory.MakePunter("Marina", MarRadioBtn, MarTxtBox);

            //Defining Apple
            LuckyApple = new Apple(0, Apple, false);

        }

        private async void RaceBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string results = "";
            string betResults = "";
            TrophyImg.Enabled = false;
            TrackHorseSpeed.Visible = true;
            HorseSpeedLbl.Visible = true;
            int[] horseSpeed = {2000, 1000, 500, 250, 100, 75, 50, 25, 10}; //Max is 8 due to TrackerBar

            while (results == "") //Run til we have a winner
            {
                //Horses all run
                for (int i = 0; i < Horses.Length; i++)
                {
                    Horses[i].Run(rand.Next(1, 50), LuckyApple);

                    if (Horses[i].Picture.Location.X == 12 && Horses[i].LapNum == 1 && results == "") //Current only winner
                    {
                        results = Horses[i].Name + "(" + Horses[i].Num + ") is the Winner!";
                    }
                    else if (Horses[i].Picture.Location.X == 12 && Horses[i].LapNum == 1 && results != "") //Multiple winners
                    {
                        results = "Tie!";
                        break;
                    }
                }

                //Repeats after tiny break
                await Task.Delay(horseSpeed[TrackHorseSpeed.Value]);
            }

            TrackHorseSpeed.Visible = false;
            HorseSpeedLbl.Visible = false;

            //Winners receive their money
            for (int i = 0; i < Punters.Length; i++)
            {
                Punters[i].PayMe(results, betResults, out string payResults, Punters);
                betResults = payResults;
            }

            RaceResultTxtBox.Visible = true;
            RaceResultTxtBox.Text = results + betResults;
            RaceBtn.Enabled = false;

            if (betResults == "") //Game is still going
            {
                RestartBtn.Visible = true;
            }
            else //Game Over
            {
                NewGameBtn.Visible = true;
            }

            await Task.Delay(1);

        } //RaceBtn End *****

        private void JacRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PunterMoneyLbl.Text = Punters[0].Name + " Bets:";
            MaxBetTxtBox.Text = "Max Bet is $" + Punters[0].TotMoney;
            BetMoneyNumBox.Maximum = Punters[0].TotMoney;
        }

        private void MelRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PunterMoneyLbl.Text = Punters[1].Name + " Bets:";
            MaxBetTxtBox.Text = "Max Bet is $" + Punters[1].TotMoney;
            BetMoneyNumBox.Maximum = Punters[1].TotMoney;
        }

        private void MarRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PunterMoneyLbl.Text = Punters[2].Name + " Bets:";
            MaxBetTxtBox.Text = "Max Bet is $" + Punters[2].TotMoney;
            BetMoneyNumBox.Maximum = Punters[2].TotMoney;
        }

        private void BetBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Punters.Length; i++)
            {
                if (Punters[i].RadioBtn.Checked == true)
                {
                    Punters[i].Betting(new Bet(Horses[Convert.ToInt32(BetHorseNumBox.Value) - 1], Convert.ToInt32(BetMoneyNumBox.Value)));
                    Punters[i].TxtBox.Text = Punters[i].Name + " betted $" + BetMoneyNumBox.Value + " on " + Horses[Convert.ToInt32(BetHorseNumBox.Value) - 1].Name
                        + "(" + BetHorseNumBox.Value + ").";

                    Punters[i].RadioBtn.Checked = false;
                    Punters[i].RadioBtn.Enabled = false;
                }
            }

            if (Punters[0].RadioBtn.Enabled == false && Punters[1].RadioBtn.Enabled == false && Punters[2].RadioBtn.Enabled == false) //If all bets are in
            {
                BetBtn.Enabled = false;
                RaceBtn.Enabled = true;
                TrophyImg.Enabled = true;
            }

        } //BetBtn End *****

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartBtn.Visible = false;
            BetBtn.Enabled = true;
            RaceResultTxtBox.Visible = false;
            LuckyApple.LaneNum = 0;

            //Disenabling Apple
            LuckyApple.Reset();

            for (int i = 0; i < Horses.Length; i++) //Sending all horses back to start
            {
                Horses[i].Back2Start();
            }

            for (int i = 0; i < Punters.Length; i++) //Getting new bets
            {
                Punters[i].NextRace();
            }

        } //RestartBtn ends

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGameBtn.Visible = false;
            BetBtn.Enabled = true;
            RaceResultTxtBox.Visible = false;
            Factory.count = 3; //All Punters are back in
            MaxBetTxtBox.Text = "Max Bet is $50";

            //Disenabling Apple
            LuckyApple.Reset();

            for (int i = 0; i < Horses.Length; i++) //Sending all horses back to start
            {
                Horses[i].Back2Start();
            }

            for (int i = 0; i < Punters.Length; i++) //Giving Punters $50
            {
                Punters[i].NewGame();
            }
        } //NewGameBtn ends

        private void TrophyImg_Click(object sender, EventArgs e)
        {

            if (LuckyApple.LaneNum == 0) //ENsures you cant change apple once in
            {
                Random rand = new Random();

                //Placing lucky apple
                LuckyApple = new Apple(rand.Next(1, 5), Apple, rand.Next(0, 8) == 0 ? true : false); //Determines is Apple is rotten or fresh

                LuckyApple.PlaceApple();
            }

        }
    }
}
