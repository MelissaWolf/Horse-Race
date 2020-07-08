using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_Race
{
    public class Bet
    {
        public Horse HorseBetOn { get; set; }

        public int MoneyBet { get; set; }

        public Bet(Horse horseBetOn, int moneyBet)
        {
            HorseBetOn = horseBetOn;
            MoneyBet = moneyBet;
        }
    }
}
