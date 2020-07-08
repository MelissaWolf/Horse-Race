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
    }
}
