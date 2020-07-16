using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Jack : Punter
    {
        public override string Name { get; set; }

        public override int TotMoney { get; set; }

        public override RadioButton RadioBtn { get; set; }

        public override TextBox TxtBox { get; set; }

        public override Bet MyBet { get; set; }

        public Jack(string name, int totMoney, RadioButton radiobtn, TextBox txtBox)
        {
            Name = name;
            TotMoney = totMoney;
            RadioBtn = radiobtn;
            TxtBox = txtBox;
        }

        public override void Betting(Bet bet)
        {
            MyBet = bet;
        }
    }
}
