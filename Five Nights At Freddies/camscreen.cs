using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class camscreen : UserControl
    {
        Stopwatch camtimer = new Stopwatch();

        Image campflipimage = Properties.Resources.camflip_1;

        int clock = 40;
        public camscreen()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            Bitmap resized = new Bitmap(Properties.Resources.camerabuttonimage, new Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32));
            camerabutton.BackgroundImage = resized;
            camerabutton.Size = new System.Drawing.Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32);
            camerabutton.Location = new System.Drawing.Point(Form1.sizex / 16 * 3, Form1.sizey - camerabutton.Height);
            camerabutton.Enabled = true;

            camfliplabel.Text = "";
            camfliplabel.Size = new System.Drawing.Size(Form1.sizex, Form1.sizey);
            camfliplabel.Location = new Point(0, 0);

            camerabutton.BringToFront();

            camerabutton.Enabled = true;
        }
        private void camscreen_MouseEnter(object sender, EventArgs e)
        {
            camerabutton.Enabled = false;
        }
        private void camscreen_MouseLeave(object sender, EventArgs e)
        {
            camerabutton.Enabled = true;
        }
        private void camtimer_Tick(object sender, EventArgs e)
        {
            if (camtimer.IsRunning)
            {
                if (camtimer.ElapsedMilliseconds <= clock)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_11, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 2)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_10, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 3)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_9, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 4)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_8, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 5)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_7, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 6)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_6, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 7)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_5, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 8)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_4, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 9)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_3, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 10)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_2, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 11)
                {
                    Bitmap resized = new Bitmap(Properties.Resources.camflip_1, new Size(Form1.sizex, Form1.sizey));
                    campflipimage = resized;
                }
                else if (camtimer.ElapsedMilliseconds > clock * 11)
                {
                    Form1.ChangeScreen(this, new Game_screen());
                    camtimer.Reset();
                }
            }
            Refresh();
        }
        private void camscreen_MouseHover(object sender, EventArgs e)
        {
            //Form1.ChangeScreen(this, new Game_screen());
        }
        private void camerabutton_MouseEnter(object sender, EventArgs e)
        {
            camerabutton.Enabled = false;
            camerabutton.Visible = false;
            camtimer.Start();
            cameratimer.Start();
        }
        private void camscreengametimer_Tick(object sender, EventArgs e)
        { 
            camfliplabel.Image = campflipimage;
        }
    }
}