using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Dodge
{
    class Asteroid
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image asteroidImage;//variable for the Asteroid's image

        public Rectangle asteroidRec;//variable for a rectangle to place our image in
        // Methods for the Asteroid class
        public void DrawPlanet(Graphics g)
        {
            asteroidRec = new Rectangle(x, y, width, height);
            g.DrawImage(asteroidImage, asteroidRec);
        }

        public void MoveAsteroid()
        {
            asteroidRec.Location = new Point(x, y);
        }

        //Create a constructor (initialises the values of the fields)
        public Asteroid(int spacing)
        {
            x = spacing;
            y = -76;
            width = 20;
            height = 50;
            //AsteroidImage contains the asteroid.png image
            asteroidImage = Properties.Resources.Asteroid;
            asteroidRec = new Rectangle(x, y, width, height);
        }
    }
}
