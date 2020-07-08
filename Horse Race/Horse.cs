using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public class Horse
    {
        public string Name { get; set; }

        public int Num { get; set; }

        public PictureBox Picture { get; set; }

        public int LapNum = 0;

        public Horse(string name, int num, PictureBox picture)
        {
            Name = name;
            Num = num;
            Picture = picture;
        }

        public void Run(int speed)
        {
            if (LapNum == 1)
            { //Horse is running left
                Picture.Location = new Point((Picture.Location.X - speed <= 12 ? 12 : Picture.Location.X - speed), Picture.Location.Y);
            }
            else if (Picture.Location.X + speed > 1100)
            { //Horse touches right line
                speed = (Picture.Location.X + speed) - 1100;
                Picture.Location = new Point(1100 - speed, Picture.Location.Y);
                Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                Console.WriteLine("LineTouch by "+LapNum);

                LapNum = 1;
            }
            else
            { //Horse is running right
                Picture.Location = new Point(Picture.Location.X + speed, Picture.Location.Y);
            }
        }
    }
}
