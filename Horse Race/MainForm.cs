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

        //Creating Bets
        Bet JacBet;
        Bet MelBet;
        Bet MarBet;

        Bet[] AllBets = new Bet[3];

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

            Punters[0] = Factory.MakePunter("Jack", JacRadioBtn, JacTxtBox, JacBet);
            Punters[1] = Factory.MakePunter("Melissa", MelRadioBtn, MelTxtBox, MelBet);
            Punters[2] = Factory.MakePunter("Marina", MarRadioBtn, MarTxtBox, MarBet);
        }

        private async void RaceBtn_Click(object sender, EventArgs e)
        {
            Random speed = new Random();
            string results = "";

            while (results == "") //Run til we have a winner
            {
                //Horses all run
                for (int i = 0; i < Horses.Length; i++)
                {
                    Horses[i].Run(speed.Next(1, 50));

                    if (Horses[i].Picture.Location.X == 12 && Horses[i].LapNum == 1 && results == "") //Current only winner
                    {
                        results = Horses[i].Name + "(" + Horses[i].Num + ") is the Winner!";
                    }
                    else if (Horses[i].Picture.Location.X == 12 && Horses[i].LapNum == 1 && results != "")
                    { //Multiple winners
                        results = "Tie!";
                        break;
                    }
                }

                //Repeats after tiny break
                await Task.Delay(50);
            }

            RaceResultTxtBox.Visible = true;
            RaceResultTxtBox.Text = results;

            //Winners receive their money
            for (int i = 0; i < Punters.Length; i++)
            {
                if (results.Contains(AllBets[i].HorseBetOn.Name) == true && Punters[i].TotMoney > 0) //If horse wins
                {
                    Punters[i].TotMoney = Punters[i].TotMoney + (AllBets[i].MoneyBet * 2);
                    Punters[i].TxtBox.Text = Punters[i].Name + " just won " + (AllBets[i].MoneyBet * 2) + " they now have a total of $" + Punters[i].TotMoney + ".";
                }
                else if (Punters[i].TotMoney > 0)
                { //Horse did not win
                    Punters[i].TotMoney = Punters[i].TotMoney - AllBets[i].MoneyBet;

                    if (Punters[i].TotMoney > 0)
                    {
                        Punters[i].TxtBox.Text = Punters[i].Name + " lost $" + AllBets[i].MoneyBet + " they now have a total of $" + Punters[i].TotMoney + ".";
                    }
                    else
                    {
                        Punters[i].TxtBox.Text = Punters[i].Name + " is broke :(";
                    }
                }
            }

            RaceBtn.Enabled = false;
            RestartBtn.Visible = true;

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
                    AllBets[i] = (Punters[i].MyBet = new Bet(Horses[Convert.ToInt32(BetHorseNumBox.Value) - 1], Convert.ToInt32(BetMoneyNumBox.Value)));
                    Punters[i].TxtBox.Text = Punters[i].Name + " betted $" + BetMoneyNumBox.Value + " on " + Horses[Convert.ToInt32(BetHorseNumBox.Value) - 1].Name
                        + " (" + BetHorseNumBox.Value + ").";

                    Punters[i].RadioBtn.Checked = false;
                    Punters[i].RadioBtn.Enabled = false;
                }
            }

            if (Punters[0].RadioBtn.Enabled == false && Punters[1].RadioBtn.Enabled == false && Punters[2].RadioBtn.Enabled == false) //If all bets are in
            {
                BetBtn.Enabled = false;
                RaceBtn.Enabled = true;
            }

            //Debug.WriteLine(Horses.Where<Horse>(x=>x.Picture.Image.))

        } //BetBtn End *****

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartBtn.Visible = false;
            BetBtn.Enabled = true;
            RaceResultTxtBox.Visible = false;

            for (int i = 0; i < Horses.Length; i++) //Sending all horses back to start
            {
                Horses[i].Picture.Location = new Point(12, Horses[i].Picture.Location.Y);

                if (Horses[i].LapNum != 0) {
                    Console.WriteLine("ResartBtn" + Horses[i].LapNum);
                    Horses[i].Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    Horses[i].LapNum = 0;
                }
            }

            for (int i = 0; i < Punters.Length; i++) //Getting new bets
            {
                if (Punters[i].TotMoney != 0)
                {
                    Punters[i].RadioBtn.Enabled = true;
                    Punters[i].TxtBox.Text = Punters[i].Name + " place your bet";
                }
            }

        }

    }
}
