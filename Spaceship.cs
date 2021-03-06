using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Dodge
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the spaceship's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        //methods
        public void DrawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }

        public void MoveSpaceship(string move)
        {
            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 6;
                    spaceRec.Location = new Point(x, y);
                }

            }
            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 6;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 9;
                    spaceRec.Location = new Point(x, y);
                }

            }
        }

        public Spaceship()
        {
            x = 230;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Properties.Resources.spacecraft;
            spaceRec = new Rectangle(x, y, width, height);
        }
    }
}
