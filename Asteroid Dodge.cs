using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_Dodge
{
    public partial class Asteroid_Dodge : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called asteroid 

        public Asteroid_Dodge()
        {
            InitializeComponent();
            

        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MnuStop2_Click(object sender, EventArgs e)
        {
            this.Close();
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
           
        }
   

        private void MnuStart_MouseEnter(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame2;
        }

        private void MnuStart_MouseLeave(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame;
        }

        private void Asteroid_Dodge_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Use the left and right arrow keys or A and D to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point and collecting a coin gets 5. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name \n Click Start to begin", "Game Instructions");
            TxtName.Focus();
        }
    }
}
