using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Asteroid_Dodge
{
    public partial class Asteroid_Dodge : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called asteroid 
        Asteroid[] asteroid = new Asteroid[7];
        Random yspeed = new Random();
        bool left, right;
        int score, lives;
        string move;
        Spaceship spaceship = new Spaceship();

        public Asteroid_Dodge()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                asteroid[i] = new Asteroid(x);
            }
            TxtName.ReadOnly = false;
        }

        private void MnuStart_Click_1(object sender, EventArgs e)
        {
            TxtNameCopy.MaxLength = 5;
            if (TxtNameCopy.Text.Length < 1)
            {
                MessageBox.Show("Please enter a name.");
                return /*false*/;
            }

            panel2.Visible = false;
            TmrAsteriod.Enabled = true;
            TmrSpaceship.Enabled = true;

            // Paste current text in Clipboard into text box.
            TxtNameCopy.SelectionStart = 0;
            TxtNameCopy.SelectionLength = TxtNameCopy.TextLength;
            TxtNameCopy.Copy();

            TxtName.SelectionStart = 0;
            TxtName.Paste();
            TxtNameCopy.SelectionStart = 0;

            return /*true*/;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Asteroid class's DrawPlanet method to draw the image asteroid1 
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 25);
                spaceship.DrawSpaceship(g);
                asteroid[i].y += rndmspeed;
                //call the Planet class's drawPlanet method to draw the images
                asteroid[i].DrawAsteroid(g);
            }
        }

        private void TmrAsteriod_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                asteroid[i].MoveAsteroid();
                if (spaceship.spaceRec.IntersectsWith(asteroid[i].asteroidRec))
                {
                    //reset planet[i] back to top of panel
                    asteroid[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }
                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (asteroid[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    LblScore.Text = score.ToString();// display score
                    asteroid[i].y = 30;
                }
            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrAsteriod.Enabled = false;
                TmrSpaceship.Enabled = false;
                MessageBox.Show("Game Over");
                this.Close();
            }
        }

        private void TmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.MoveSpaceship(move);
            }
        }

        private void Asteroid_Dodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
        }

        private void Asteroid_Dodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
        }

        private void MnuStart_MouseEnter(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame2;
        }

        private void MnuStart_MouseLeave(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            this.Close();
            TmrAsteriod.Enabled = false;
            TmrSpaceship.Enabled = false;
        }
        private void MnuStop2_Click(object sender, EventArgs e)
        {
            this.Close();
            TmrAsteriod.Enabled = false;
            TmrSpaceship.Enabled = false;
        }

        private void Asteroid_Dodge_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(" Use the left and right arrow keys or A and D to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point and collecting a coin gets 5. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name \n Click Start to begin", "Game Instructions");
            //TxtName.Focus();
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
        }
    }
}