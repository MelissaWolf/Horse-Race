﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Marina : Punter
    {
        public override string Name { get; set; }

        public override int TotMoney { get; set; }

        public override RadioButton RadioBtn { get; set; }

        public override TextBox TxtBox { get; set; }

        public override Bet MyBet { get; set; }

        public Marina(string name, int totMoney, RadioButton radiobtn, TextBox txtBox, Bet myBet)
        {
            Name = name;
            TotMoney = totMoney;
            RadioBtn = radiobtn;
            TxtBox = txtBox;
            MyBet = myBet;
        }
    }
}
