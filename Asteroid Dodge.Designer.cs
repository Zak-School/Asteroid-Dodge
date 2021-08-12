
namespace Asteroid_Dodge
{
    partial class Asteroid_Dodge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MnuStart = new System.Windows.Forms.Button();
            this.TxtNameCopy = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MnuStop = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MnuStop2 = new System.Windows.Forms.PictureBox();
            this.TmrAsteriod = new System.Windows.Forms.Timer(this.components);
            this.TmrSpaceship = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MnuStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MnuStop2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlGame.Location = new System.Drawing.Point(3, 36);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(500, 410);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.MnuStart);
            this.panel2.Controls.Add(this.TxtNameCopy);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.MnuStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 449);
            this.panel2.TabIndex = 503;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Image = global::Asteroid_Dodge.Properties.Resources.bg_name;
            this.label4.Location = new System.Drawing.Point(141, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Please Enter Your Name below";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Asteroid_Dodge.Properties.Resources.Asteroid_Dodge_White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MnuStart
            // 
            this.MnuStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MnuStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MnuStart.FlatAppearance.BorderSize = 0;
            this.MnuStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MnuStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MnuStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MnuStart.Image = global::Asteroid_Dodge.Properties.Resources.playgame;
            this.MnuStart.Location = new System.Drawing.Point(228, 115);
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(136, 36);
            this.MnuStart.TabIndex = 15;
            this.MnuStart.UseVisualStyleBackColor = true;
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click_1);
            this.MnuStart.MouseEnter += new System.EventHandler(this.MnuStart_MouseEnter);
            this.MnuStart.MouseLeave += new System.EventHandler(this.MnuStart_MouseLeave);
            // 
            // TxtNameCopy
            // 
            this.TxtNameCopy.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNameCopy.Location = new System.Drawing.Point(228, 336);
            this.TxtNameCopy.MaxLength = 10;
            this.TxtNameCopy.Name = "TxtNameCopy";
            this.TxtNameCopy.Size = new System.Drawing.Size(145, 20);
            this.TxtNameCopy.TabIndex = 13;
            this.TxtNameCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.ErrorImage = global::Asteroid_Dodge.Properties.Resources.bg_name;
            this.pictureBox5.Image = global::Asteroid_Dodge.Properties.Resources.bg_name;
            this.pictureBox5.Location = new System.Drawing.Point(121, 238);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(348, 171);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // MnuStop
            // 
            this.MnuStop.Image = global::Asteroid_Dodge.Properties.Resources.exit;
            this.MnuStop.Location = new System.Drawing.Point(272, 171);
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(44, 43);
            this.MnuStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MnuStop.TabIndex = 2;
            this.MnuStop.TabStop = false;
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lives";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(240, 16);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(13, 13);
            this.LblLives.TabIndex = 11;
            this.LblLives.Text = "5";
            // 
            // LblScore
            // 
            this.LblScore.Location = new System.Drawing.Point(376, 6);
            this.LblScore.Name = "LblScore";
            this.LblScore.ReadOnly = true;
            this.LblScore.Size = new System.Drawing.Size(85, 20);
            this.LblScore.TabIndex = 10;
            this.LblScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(44, 7);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(85, 20);
            this.TxtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // MnuStop2
            // 
            this.MnuStop2.Image = global::Asteroid_Dodge.Properties.Resources.exit;
            this.MnuStop2.Location = new System.Drawing.Point(523, 3);
            this.MnuStop2.Name = "MnuStop2";
            this.MnuStop2.Size = new System.Drawing.Size(44, 43);
            this.MnuStop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MnuStop2.TabIndex = 13;
            this.MnuStop2.TabStop = false;
            this.MnuStop2.Click += new System.EventHandler(this.MnuStop2_Click);
            // 
            // TmrAsteriod
            // 
            this.TmrAsteriod.Tick += new System.EventHandler(this.TmrAsteriod_Tick);
            // 
            // TmrSpaceship
            // 
            this.TmrSpaceship.Interval = 50;
            this.TmrSpaceship.Tick += new System.EventHandler(this.TmrSpaceship_Tick);
            // 
            // Asteroid_Dodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 449);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MnuStop2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Asteroid_Dodge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asteroid Dodge";
            this.Load += new System.EventHandler(this.Asteroid_Dodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Asteroid_Dodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Asteroid_Dodge_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MnuStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MnuStop2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.TextBox LblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox MnuStop;
        private System.Windows.Forms.TextBox TxtNameCopy;
        private System.Windows.Forms.Button MnuStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MnuStop2;
        private System.Windows.Forms.Timer TmrAsteriod;
        private System.Windows.Forms.Timer TmrSpaceship;
    }
}

