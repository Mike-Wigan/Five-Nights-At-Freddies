using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Five_Nights_At_Freddies
{
    public partial class Main_Menu : UserControl
    {

        Stopwatch statictimer = new Stopwatch();

        Random randnum = new Random();

        Pen redpen = new Pen(Color.Red);

        public static Bitmap Static1;
        public static Bitmap Static2;
        public static Bitmap Static3;
        public static Bitmap Static4;
        public static Bitmap Static5;
        public static Bitmap Static6;
        public static Bitmap Static7;
        public static Bitmap fnaf1;
        public static Bitmap fnaf2;
        public static Bitmap fnaf3;
        public static Bitmap fnaf4;

        Bitmap background = Properties.Resources.fnaf_1_1;
        public static Bitmap Static = Properties.Resources.static_1;

        int time = 30;
        int counter;
        int rand;
        public Main_Menu()
        {
            InitializeComponent();

            label1.Location = new Point(Form1.sizex / 15, Form1.sizey / 8);

            Newgamebutton.Text = $"New Game";
            Newgamebutton.Size = new System.Drawing.Size(200, 50);
            Newgamebutton.Enabled = true;
            Newgamebutton.Location = new Point(Form1.sizex / 15, Form1.sizey - Form1.sizey / 3);
            Newgamebutton.TextAlign = ContentAlignment.MiddleRight;
            Newgamebutton.BackColor = Color.Transparent;

            Continuebutton.Text = $"Continue";
            Continuebutton.Size = new System.Drawing.Size(200, 50);
            Continuebutton.Enabled = true;
            Continuebutton.Location = new Point(Form1.sizex / 15, Form1.sizey - Form1.sizey / 4);
            Continuebutton.TextAlign = ContentAlignment.MiddleRight;
            Continuebutton.BackColor = Color.Transparent; 
            
            fnaf1 = new Bitmap(Form1.mainmenu1, new Size(Form1.sizex, Form1.sizey));
            fnaf2 = new Bitmap(Form1.mainmenu2, new Size(Form1.sizex, Form1.sizey));
            fnaf3 = new Bitmap(Form1.mainmenu3, new Size(Form1.sizex, Form1.sizey));
            fnaf4 = new Bitmap(Form1.mainmenu4, new Size(Form1.sizex, Form1.sizey));

            Static1 = new Bitmap(Form1.staticimage1, new Size(Form1.sizex, Form1.sizey));
            Static2 = new Bitmap(Form1.staticimage2, new Size(Form1.sizex, Form1.sizey));
            Static3 = new Bitmap(Form1.staticimage3, new Size(Form1.sizex, Form1.sizey));
            Static4 = new Bitmap(Form1.staticimage4, new Size(Form1.sizex, Form1.sizey));
            Static5 = new Bitmap(Form1.staticimage5, new Size(Form1.sizex, Form1.sizey));
            Static6 = new Bitmap(Form1.staticimage6, new Size(Form1.sizex, Form1.sizey));
            Static7 = new Bitmap(Form1.staticimage7, new Size(Form1.sizex, Form1.sizey));

            statictimer.Start();
        }
        private void Newgamebutton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Game_screen());
        }
        private void Continuebutton_Click(object sender, EventArgs e)
        {
            //take xml files idk how to yet later project
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            #region freddie change screen 
            if (counter == 10 || counter == 0)
            {
                rand = randnum.Next(1, 600);
            }
            if (counter == 10)
            {
                counter = 0;
            }

            if (randnum.Next(1, 500) >= 492 || counter > 1 && counter < 10)
            {
                counter++;
                if (rand > 0 && rand < 201)
                {
                    background = fnaf2;
                }
                if (rand > 200 && rand < 401)
                {
                    background = fnaf3;
                }
                if (rand > 400 && rand < 601)
                {
                    background = fnaf4;
                }
            }
            else
            {
                background = fnaf1;
            }
            #endregion

            #region static
            if (statictimer.ElapsedMilliseconds <= time)
            {
                Static = Static1;
            }
            else if (statictimer.ElapsedMilliseconds <= time * 1.5)
            {
                Static = Static2;
            }
            else if (statictimer.ElapsedMilliseconds <= time * 2)
            {
                Static = Static3;
            }
            else if (statictimer.ElapsedMilliseconds <= time * 2.5)
            {
                Static = Static4;
            }
            else if (statictimer.ElapsedMilliseconds <= time * 3)
            {
                Static = Static5;
            }
            else if (statictimer.ElapsedMilliseconds <= time * 3.5)
            {
                Static = Static6;
            }
            else if (statictimer.ElapsedMilliseconds >= time * 4)
            {
                Static = Static7;
                statictimer.Restart();
            }

            #endregion

            

            Refresh();
        }
        private void Main_Menu_Paint(object sender, PaintEventArgs e)
        { 
            e.Graphics.DrawImage(background, 0, 0);
            e.Graphics.DrawImage(Static, 0, 0);  
        }
        private void Newgamebutton_MouseEnter(object sender, EventArgs e)
        {
            Newgamebutton.Text = "> New Game";
        }
        private void Continuebutton_MouseEnter(object sender, EventArgs e)
        {
            Continuebutton.Text = "> continue";
        }
        private void Newgamebutton_MouseLeave(object sender, EventArgs e)
        {
            Newgamebutton.Text = "New Game";
        }
        private void Continuebutton_MouseLeave(object sender, EventArgs e)
        {
            Continuebutton.Text = "continue";
        }
    }
}
