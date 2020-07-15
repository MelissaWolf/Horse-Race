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

        public void Run(int speed, Apple LuckyApple)
        {

            if (LapNum == 1) //Horse is running left
            {
                Picture.Location = new Point((Picture.Location.X - speed <= 12 ? 12 : Picture.Location.X - speed), Picture.Location.Y);
            }
            else if (Picture.Location.X + speed > 1100) //Horse touches right line and turns around
            {
                speed = (Picture.Location.X + speed) - 1100;
                Picture.Location = new Point(1100 - speed, Picture.Location.Y);
                Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

                LapNum = 1;
            }
            else //Horse is running right
            {

                if (Picture.Location.X + speed >= 360 && LuckyApple.LaneNum == Num) //If horse touches apple
                {
                    if (LuckyApple.Rotten == true) //Horse stops by bad apple
                    {
                        Picture.Location = new Point(360, Picture.Location.Y);
                        speed = 0;
                    }
                    else //Horse gets speed boost
                    {
                        speed = speed + 15;
                        LuckyApple.Picture.Visible = false; //Because Apple is eaten
                    }
                }

                Picture.Location = new Point(Picture.Location.X + speed, Picture.Location.Y);
            }
        }

        public void Back2Start() //Sends horses back to start
        {
            Picture.Location = new Point(-27, Picture.Location.Y);

            if (LapNum != 0)
            {
                Picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                LapNum = 0;
            }
        }
    }
}
