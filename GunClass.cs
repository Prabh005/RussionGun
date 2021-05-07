using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RussionGun
{
  public  class GunClass
    {
      //  SoundPlayer s = new SoundPlayer(RussionGun.Properties.Resources.sound);
        public int bullet; // bullet
        public int spin = 0; // spin
        public int fire = 0; // fire 
        public int away = 2; // shoot away
        public int Point = 0; // point


        public void Loadgun()
        {
            bullet = 1;
        }

        public void Spin()
        {
          // random number 
            Random myrand = new Random();
            bullet = myrand.Next(1, 6);
        }

        public void shootaway()
        {
            
            bullet = bullet + 1;
        }
        public void Bullet()
        {
            if (bullet < 6)
            {
              
                Console.WriteLine("Bullet is at: " + bullet);
            }
        }

        public void Pointadd()
        {
           // add 10 points per win
            Point = Point + 10;
        }
        public void Pointadd1()
        {
           // shootaway adding 5 poingts 
            Point = Point + 5;
        }
        public void PointCut()
        {
            // dead loose 5 points 
            Point = Point - 5;
        }

        public void fireshot()
        {
            
            fire = fire + 1;
            spin = fire + away;
        }
        public void awayshot()
        {
           
            away = away + 1;
            spin = fire + away;
        }

       

    }
}
