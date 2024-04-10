using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Main_Menu : UserControl
    {
        bool Exit = false;
        public Main_Menu()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Main_Meny_KeyDown);
            this.BackColor = Color.Black;
            label1.Text = $"New Game";
            label2.Text = $"Continue";
            label1.Size = new System.Drawing.Size(150, 50);
            label2.Size = new System.Drawing.Size(150, 50);
            label1.Location = new System.Drawing.Point(this.Width / 4, (this.Height / 4) * 6);
            label2.Location = new System.Drawing.Point(this.Width / 4, label1.Location.Y + label2.Height + 30);
            Newgamebutton.Text = $">>";
            Continuebutton.Text = $">>";
            Newgamebutton.Size = new System.Drawing.Size(200, 50);
            Continuebutton.Size = new System.Drawing.Size(200, 50);
            Newgamebutton.Location = new System.Drawing.Point(label1.Location.X - 50, label1.Location.Y - 13);
            Continuebutton.Location = new System.Drawing.Point(label2.Location.X - 50, label2.Location.Y - 13);
            //KeyUp = Main_Menu_KeyUp;
            KeyDown += Main_Menu_KeyDown;
            KeyUp += Main_Menu_KeyUp;


        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Newgamebutton_Click(object sender, EventArgs e)
        {

        }
        private void Continuebutton_Click(object sender, EventArgs e)
        {

        }

        private void Main_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    label1.Text = $"button working";
                    //Application.Exit();
                    Exit = true;
                    break;
            }
        }
        private void Main_Menu_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    label1.Text = $"button up";
                    break;
            }   

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Exit == true)
            {
                Application.Exit();
            }
        }
    }
}
