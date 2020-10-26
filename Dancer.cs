using System;
using System.Drawing;

namespace FacebookApplicationUI
{
    public class Dancer
    {
        private Random RandomNum { get; set; }

        public Dancer()
        {
            RandomNum = new Random();
        }

        public void MakeDance(IDanceable i_DanceAbleObject)
        {
            int radios = 200;
            int i = 0;
            Point originalLocation = i_DanceAbleObject.Location;
            Color originalBackColor = i_DanceAbleObject.BackColor;
            Point statingPoint = new Point(1, 1);

            i_DanceAbleObject.Location = statingPoint;

            while (i_DanceAbleObject.Location != originalLocation)
            {
                double radianDegree = i * Math.PI / 180;
                i_DanceAbleObject.Location = new Point((int)(originalLocation.X + Math.Cos(radianDegree) * radios), (int)(originalLocation.Y + Math.Sin(radianDegree) * radios));
                i_DanceAbleObject.BackColor = Color.FromArgb(RandomNum.Next(255), RandomNum.Next(255), RandomNum.Next(255));

                radios = i < 1080 ? (radios + 1) : (radios - 1);
                i++;
            }

            i_DanceAbleObject.BackColor = originalBackColor;
            i_DanceAbleObject.Location = originalLocation;
        }
    }
}