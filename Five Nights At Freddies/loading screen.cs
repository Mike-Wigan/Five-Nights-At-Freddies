using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Five_Nights_At_Freddies
{
    public partial class loading_screen : UserControl
    {
        Pen whitepen = new Pen(Color.White, 3);
        Stopwatch stopwatch = new Stopwatch();
        public loading_screen()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Size = new System.Drawing.Size(Form1.sizex, Form1.sizey);
            pausetimer.Start();
            stopwatch.Start();
        }

        private void pausetimer_Tick(object sender, EventArgs e)
        {
            if (Game_screen.gameoverbool == true)
            {
                this.BackgroundImage = Form1.cheque;
            }
                if (stopwatch.ElapsedMilliseconds >= 5000)
                {
                    if (Form1.screen == "main menu")
                    {
                        Form1.ChangeScreen(this, new Game_screen());
                        pausetimer.Stop();
                    }
                    else if (Form1.screen == "game screen")
                    {

                        Form1.ChangeScreen(this, new Main_Menu());
                        pausetimer.Stop();
                    }
                }
                else if (stopwatch.ElapsedMilliseconds < 5000 && Game_screen.gameoverbool == false)
                {
                    Bitmap paper = new Bitmap(Form1.paper, new Size(Form1.sizex, Form1.sizey));
                    this.BackgroundImage = paper;
                }
        }

        private void loading_screen_Paint(object sender, PaintEventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds >= 5000)
            {
                e.Graphics.DrawEllipse(whitepen, Form1.sizex - Form1.sizex / 19, Form1.sizey - Form1.sizex / 19, Form1.sizex / 20, Form1.sizex / 20);
                e.Graphics.DrawLine(whitepen, Form1.sizex - Form1.sizex / 35, Form1.sizey - Form1.sizex / 35, Form1.sizex - Form1.sizex / 35, Form1.sizey - Form1.sizex / 20);
            }
        }
    }
}
