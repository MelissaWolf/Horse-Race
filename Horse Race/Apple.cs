using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Apple
    {
        public int LaneNum { get; set; }

        public PictureBox Picture { get; set; }

        public bool Rotten { get; set; }

        public Apple(int laneNum, PictureBox picture, bool rotten)
        {
            LaneNum = laneNum;
            Picture = picture;
            Rotten = rotten;
        }

        public void PlaceApple() //Assigning the apple a lane
        {
            //Placing apple in correct lane
            Picture.Location = new Point(490, (LaneNum * 110) - 80);
            Picture.Visible = true;

            if (Rotten == true) //Changing picture to BadApple if Rotten
            {
                Picture.Image = Horse_Race.MainResource.BadApple;
            }
            else
            { //Changing picture to Apple
                Picture.Image = Horse_Race.MainResource.Apple;
            }
        }

        public void Reset() //Getting Apple out of race for next round
        {
            LaneNum = 0;
            Picture.Visible = false;
        }
    }
}
