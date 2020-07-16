using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public abstract class Punter
    {
        public abstract string Name { get; set; }

        public abstract int TotMoney { get; set; }

        public abstract RadioButton RadioBtn { get; set; }

        public abstract TextBox TxtBox { get; set; }

        public abstract Bet MyBet { get; set; }

        public void PayMe(string results, string currParResults, out string payResults, Punter[] Punters)
        {
            payResults = currParResults; //Ensures to keep any current result.

            if (results.Contains(MyBet.HorseBetOn.Name) == true && TotMoney > 0 && results != "Tie!") //If horse wins
            {
                TotMoney = TotMoney + (MyBet.MoneyBet * 2);
                TxtBox.Text = Name + " just won $" + (MyBet.MoneyBet * 2) + " they now have a total of $" + TotMoney + ".";
            }
            else if (TotMoney > 0 && results != "Tie!") //Horse did not win
            {
                TotMoney = TotMoney - MyBet.MoneyBet;

                if (TotMoney > 0) //Punter has money left
                {
                    TxtBox.Text = Name + " lost $" + MyBet.MoneyBet + " they now have a total of $" + TotMoney + ".";
                }
                else //Punter is BROKE!
                {
                    TxtBox.Text = Name + " is broke :(";

                    Factory.count--;

                    if (Factory.count == 1) //There is only 1 punter
                    {
                        for (int i = 0; i < Punters.Length; i++) //Checks for winner
                        {
                            if (Punters[i].TotMoney != 00) //Finds last punter's win
                            {
                                payResults = " " + Punters[i].Name + " is the only Punter left and Wins The Game!";
                            }
                        }

                    }
                    else if (Factory.count == 0)
                    {
                        payResults = " No Punters left to Bet. GAME OVER!";
                    }

                }
            }
            else if (results == "Tie!" && TotMoney > 0) //Horses tied round not valid
            {
                TxtBox.Text = "Race was a draw. " + Name + " keeps their $" + MyBet.MoneyBet + ".";
            }
        } //PayMe() ends

        public void NextRace() //Resets for next race
        {
            if (TotMoney != 0)
            {
                RadioBtn.Enabled = true;
                TxtBox.Text = Name + " place your bet";
            }
        }

        public void NewGame() //Resets for new game
        {
            TotMoney = 50;
            RadioBtn.Enabled = true;
            TxtBox.Text = Name + " place your bet";
        }

        public abstract void Betting(Bet bet);
    }
}
