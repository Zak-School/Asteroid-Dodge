using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Asteroid_Dodge
{
    class Coin
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image coinImage;//variable for the Asteroid's image

        public Rectangle coinRec;//variable for a rectangle to place our image in
        // Methods for the Asteroid class
        public void DrawCoin(Graphics g)
        {
            coinRec = new Rectangle(x, y, width, height);
            g.DrawImage(coinImage, coinRec);
        }

        public void MoveCoin()
        {
            coinRec.Location = new Point(x, y);
        }

        //Create a constructor (initialises the values of the fields)
        public Coin(int spacing)
        {
            x = spacing;
            y = -76;
            width = 20;
            height = 20;
            //AsteroidImage contains the asteroid.png image
            coinImage = Properties.Resources.Coin;
            coinRec = new Rectangle(x, y, width, height);
        }
    }
}