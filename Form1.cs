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
    public partial class Form1 : Form
    {
        public Form1()
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
            panel2.Visible = false;

            Clipboard.SetText(TxtNameCopy.Text);
            TxtName.Text = Clipboard.GetText();
        }
        private void MnuStart_MouseEnter(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame2;
        }

        private void MnuStart_MouseLeave(object sender, EventArgs e)
        {
            MnuStart.Image = Properties.Resources.playgame;
        }
    }
}
