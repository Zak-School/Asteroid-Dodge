using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Dodge
{
    class Missile
    {
        public int x, y, width, height;

        public Image missile;//variable for the missile's image

        public Rectangle missileRec;//variable for a rectangle to place our image in

        // in the following constructor we pass in the values of spaceRec which
        // gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located
        public Missile(Rectangle missileRec)
        {
            x = missileRec.X + 15; // move missile to middle of spaceship
            y = missileRec.Y;
            width = 20;
            height = 20;
            missile = Properties.Resources.Missile;
            missileRec = new Rectangle(x, y, width, height);
        }

        public void draw(Graphics g)
        {
            y -= 30;//speed of missile
            width = 10;
            height = 30;
            missileRec = new Rectangle(x, y, width, height);
            g.DrawImage(missile, missileRec);
        }
    }
}