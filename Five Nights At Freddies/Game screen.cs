using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Game_screen : UserControl
    {
        #region setting stuff
        public static Stopwatch camtimer = new Stopwatch();
        public static Stopwatch leftdoortimer = new Stopwatch();
        public static Stopwatch rightdoortimer = new Stopwatch();

        Stopwatch stopwatch = new Stopwatch();
        Stopwatch bonnywatch = new Stopwatch();
        Stopwatch chikawatch = new Stopwatch();
        Stopwatch freddiewatch = new Stopwatch();
        Stopwatch endwatch = new Stopwatch();

        Random random = new Random();

        int clock = 60;

        bool camscreen;
        bool officescreen = true;
        bool camright;
        bool rightlight = false, leftlight = false, leftdoor = false, rightdoor = false;
        bool rightdoordown = false;
        bool leftdoordown = false;
        bool gameoverbool = false;

        int rand;
        int counter = 1;
        int camnumber = 1;
        int click1, click2, click3, click4;
        int time = 30;
        int count = 1;
        public static int bonny = 1, freddie = 1, chika = 1, foxie = 1;

        Bitmap camflipimage = new Bitmap(Form1.cameraflipupimage1, new Size(Form1.sizex, Form1.sizey));
        Bitmap cambuttonimage = new Bitmap(Properties.Resources.camerabuttonimage, new Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32));
        public static Bitmap background = new Bitmap(Properties.Resources.office_empty, new Size(Form1.sizex, Form1.sizey));
        Bitmap leftbutton = Form1.leftbuttonsoff;
        Bitmap rightbutton = Form1.rightbuttonsoff;
        Bitmap rightdoorimage = Form1.rightdoor1;
        Bitmap leftdoorimage = Form1.leftdoor1;


        Rectangle backrec = new Rectangle(100, 0, Form1.sizex / 128 * 160, Form1.sizey);
        Rectangle rightbuttonrec = new Rectangle(Form1.sizex / 128 * 148, Form1.sizey / 128 * 50, Form1.sizex / 10, Form1.sizey / 3);
        Rectangle leftbuttonrec = new Rectangle(-Form1.sizex / 97, Form1.sizey / 128 * 50, Form1.sizex / 10, Form1.sizey / 3);
        Rectangle leftdoorrec = new Rectangle(Form1.sizex / 128 * 8, 0, Form1.sizex / 6, Form1.sizey);
        Rectangle rightdoorrec = new Rectangle(Form1.sizex, 0, Form1.sizex / 6, Form1.sizey);

        Bitmap camera;

        Freddie freddieobj = new Freddie();
        Chika chikaobj = new Chika();
        Bonny bonnyobj = new Bonny();
        #endregion
        public Game_screen()
        {
            InitializeComponent();
            setup();
        }
        private void setup()
        {
            gameoverlabel.Visible = false;
            leftlightbutton.BringToFront();
            rightlightbutton.BringToFront();
            leftdoorbutton.BringToFront();
            rightdoorbutton.BringToFront();
            leftdoorimage = Form1.leftdoor1;
            rightdoorimage = Form1.rightdoor1;
            gameTimer.Start();
            cameraButton.BackColor = Color.Transparent;
            cameraButton.BackgroundImage = cambuttonimage;
            cameraButton.Size = new System.Drawing.Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32);
            cameraButton.Location = new System.Drawing.Point(Form1.sizex / 16 * 3, Form1.sizey - cameraButton.Height);
            cameraButton.Enabled = true;

            cameraButton.BringToFront();

            cam1Abutton.Visible = false;
            cam1Bbutton.Visible = false;
            cam1Cbutton.Visible = false;
            cam2Abutton.Visible = false;
            cam2Bbutton.Visible = false;
            cam3button.Visible = false;
            cam4Abutton.Visible = false;
            cam4Bbutton.Visible = false;
            cam5button.Visible = false;
            cam6button.Visible = false;
            cam7button.Visible = false;

            cam1Abutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam1Bbutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam1Cbutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam2Abutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam2Bbutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam3button.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam4Abutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam4Bbutton.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam5button.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam6button.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);
            cam7button.Size = new Size(Form1.cammap.Width / 8, Form1.cammap.Height / 10);

            cam1Abutton.Location = new Point(Form1.sizex / 128 * 102, Form1.sizey / 128 * 81);
            cam1Bbutton.Location = new Point(Form1.sizex / 128 * 101, Form1.sizey / 128 * 88);
            cam1Cbutton.Location = new Point(Form1.sizex / 128 * 98, Form1.sizey / 128 * 99);
            cam2Abutton.Location = new Point(Form1.sizex / 128 * 102, Form1.sizey / 128 * 115);
            cam2Bbutton.Location = new Point(Form1.sizex / 128 * 102, Form1.sizey / 128 * 120);
            cam3button.Location = new Point(Form1.sizex / 128 * 97, Form1.sizey / 128 * 112);
            cam4Abutton.Location = new Point(Form1.sizex / 128 * 109, Form1.sizey / 128 * 115);
            cam4Bbutton.Location = new Point(Form1.sizex / 128 * 109, Form1.sizey / 128 * 120);
            cam5button.Location = new Point(Form1.sizex / 128 * 94, Form1.sizey / 128 * 92);
            cam6button.Location = new Point(Form1.sizex / 256 * 231, Form1.sizey / 128 * 110);
            cam7button.Location = new Point(Form1.sizex / 256 * 231, Form1.sizey / 128 * 93);

            cam1Abutton.Text = $"Cam\n1A";
            cam1Bbutton.Text = $"Cam\n1B";
            cam1Cbutton.Text = $"Cam\n1C";
            cam2Abutton.Text = $"Cam\n2A";
            cam2Bbutton.Text = $"Cam\n2B";
            cam3button.Text = $"Cam\n3";
            cam4Abutton.Text = $"Cam\n4A";
            cam4Bbutton.Text = $"Cam\n4B";
            cam5button.Text = $"Cam\n5";
            cam6button.Text = $"Cam\n6";
            cam7button.Text = $"Cam\n7";

            cam1Abutton.ForeColor = Color.White;
            cam1Bbutton.ForeColor = Color.White;
            cam1Cbutton.ForeColor = Color.White;
            cam2Abutton.ForeColor = Color.White;
            cam2Bbutton.ForeColor = Color.White;
            cam3button.ForeColor = Color.White;
            cam4Abutton.ForeColor = Color.White;
            cam4Bbutton.ForeColor = Color.White;
            cam5button.ForeColor = Color.White;
            cam6button.ForeColor = Color.White;
            cam7button.ForeColor = Color.White;


            #region images
            Form1.mainmenu1 = new Bitmap(Properties.Resources.fnaf_1_1, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.mainmenu2 = new Bitmap(Properties.Resources.fnaf_1_2, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.mainmenu3 = new Bitmap(Properties.Resources.fnaf_1_3, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.mainmenu4 = new Bitmap(Properties.Resources.fnaf_1_4, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.deathscreen = new Bitmap(Properties.Resources.fnaf_1_death, new Size(Form1.sizex, Form1.sizey));

            Form1.staticimage1 = Properties.Resources.static_1;
            Form1.staticimage2 = Properties.Resources.static_2;
            Form1.staticimage3 = Properties.Resources.static_3;
            Form1.staticimage4 = Properties.Resources.static_4;
            Form1.staticimage5 = Properties.Resources.static_5;
            Form1.staticimage6 = Properties.Resources.static_6;
            Form1.staticimage7 = Properties.Resources.static_7;

            Form1.office = new Bitmap(Properties.Resources.office_empty, new Size(Form1.sizex, Form1.sizey));

            Form1.cam1Anone = new Bitmap(Properties.Resources._1A_all, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1Aall = new Bitmap(Properties.Resources._1A_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1AFC = new Bitmap(Properties.Resources._1A_bonnie, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1AFB = new Bitmap(Properties.Resources._1A_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1AF = new Bitmap(Properties.Resources._1A_bonnie_and_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));


            Form1.cam1Bnone = new Bitmap(Properties.Resources._1B_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1BC = new Bitmap(Properties.Resources._1B_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1BF = new Bitmap(Properties.Resources._1B_freddie, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1BB = new Bitmap(Properties.Resources._1B_bonnie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam1C1 = new Bitmap(Properties.Resources._1C_1, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1C2 = new Bitmap(Properties.Resources._1C_2, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1C3 = new Bitmap(Properties.Resources._1C_3, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1C4 = new Bitmap(Properties.Resources._1C_4, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam1C5 = new Bitmap(Properties.Resources._1C_5, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam2Bnone = new Bitmap(Properties.Resources._2B_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam2BB = new Bitmap(Properties.Resources._2B_bonnie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam3none = new Bitmap(Properties.Resources._3_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam3B = new Bitmap(Properties.Resources._3_bonnie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam4Anone = new Bitmap(Properties.Resources._4Anone, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam4AC = new Bitmap(Properties.Resources._4A_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam4AF = new Bitmap(Properties.Resources._4A_freddie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam4Bnone = new Bitmap(Properties.Resources._4B_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam4BF = new Bitmap(Properties.Resources._4B_freddie, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam4BC = new Bitmap(Properties.Resources._4B_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam5none = new Bitmap(Properties.Resources._5_none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam5B = new Bitmap(Properties.Resources._5_bonnie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cam7none = new Bitmap(Properties.Resources._7none, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam7C = new Bitmap(Properties.Resources._7_chika, new Size(Form1.sizex * 4 / 3, Form1.sizey));
            Form1.cam7F = new Bitmap(Properties.Resources._7_freddie, new Size(Form1.sizex * 4 / 3, Form1.sizey));

            Form1.cameraflipupimage1 = new Bitmap(Form1.cameraflipupimage1, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage2 = new Bitmap(Form1.cameraflipupimage2, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage3 = new Bitmap(Form1.cameraflipupimage3, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage4 = new Bitmap(Form1.cameraflipupimage4, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage5 = new Bitmap(Form1.cameraflipupimage5, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage6 = new Bitmap(Form1.cameraflipupimage6, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage7 = new Bitmap(Form1.cameraflipupimage7, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage8 = new Bitmap(Form1.cameraflipupimage8, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage9 = new Bitmap(Form1.cameraflipupimage9, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage10 = new Bitmap(Form1.cameraflipupimage10, new Size(Form1.sizex, Form1.sizey));
            Form1.cameraflipupimage11 = new Bitmap(Form1.cameraflipupimage11, new Size(Form1.sizex, Form1.sizey));

            Form1.leftdoor1 = new Bitmap(Form1.leftdoor1, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor2 = new Bitmap(Form1.leftdoor2, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor3 = new Bitmap(Form1.leftdoor3, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor4 = new Bitmap(Form1.leftdoor4, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor5 = new Bitmap(Form1.leftdoor5, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor6 = new Bitmap(Form1.leftdoor6, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor7 = new Bitmap(Form1.leftdoor7, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor8 = new Bitmap(Form1.leftdoor8, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor9 = new Bitmap(Form1.leftdoor9, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor10 = new Bitmap(Form1.leftdoor10, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor11 = new Bitmap(Form1.leftdoor11, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor12 = new Bitmap(Form1.leftdoor12, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor13 = new Bitmap(Form1.leftdoor13, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.leftdoor14 = new Bitmap(Form1.leftdoor14, new Size(Form1.sizex / 6, Form1.sizey));

            Form1.rightdoor1 = new Bitmap(Form1.rightdoor1, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor2 = new Bitmap(Form1.rightdoor2, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor3 = new Bitmap(Form1.rightdoor3, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor4 = new Bitmap(Form1.rightdoor4, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor5 = new Bitmap(Form1.rightdoor5, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor6 = new Bitmap(Form1.rightdoor6, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor7 = new Bitmap(Form1.rightdoor7, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor8 = new Bitmap(Form1.rightdoor8, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor9 = new Bitmap(Form1.rightdoor9, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor10 = new Bitmap(Form1.rightdoor10, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor11 = new Bitmap(Form1.rightdoor11, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor12 = new Bitmap(Form1.rightdoor12, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor13 = new Bitmap(Form1.rightdoor13, new Size(Form1.sizex / 6, Form1.sizey));
            Form1.rightdoor14 = new Bitmap(Form1.rightdoor14, new Size(Form1.sizex / 6, Form1.sizey));

            leftlightbutton.Location = new Point(Form1.sizex / 256 * 6, Form1.sizey / 512 * 300);
            leftdoorbutton.Size = new Size(leftbuttonrec.Width / 128 * 82, leftbutton.Height / 128 * 78);
            leftlightbutton.Size = new Size(leftbuttonrec.Width / 128 * 82, leftbutton.Height / 128 * 78);
            leftdoorbutton.Location = new Point(Form1.sizex / 256 * 6, Form1.sizey / 512 * 239);
            leftlightbutton.BackColor = Color.Transparent;
            leftdoorbutton.BackColor = Color.Transparent;
            leftlightbutton.Enabled = true;
            leftdoorbutton.Enabled = true;

            rightlightbutton.Location = new Point(Form1.sizex / 256 * 255, Form1.sizey / 512 * 298);
            rightdoorbutton.Size = new Size(leftbuttonrec.Width / 128 * 82, leftbutton.Height / 128 * 78);
            rightlightbutton.Size = new Size(leftbuttonrec.Width / 128 * 82, leftbutton.Height / 128 * 78);
            rightdoorbutton.Location = new Point(Form1.sizex / 256 * 255, Form1.sizey / 512 * 239);
            rightlightbutton.BackColor = Color.Transparent;
            rightdoorbutton.BackColor = Color.Transparent;
            rightlightbutton.Enabled = true;
            rightdoorbutton.Enabled = true;
            #endregion
        }
        private void camflip_Tick(object sender, EventArgs e)
        {
            if (camscreen == false)
            {
                if (camtimer.IsRunning)
                {
                    officescreen = false;
                    if (camtimer.ElapsedMilliseconds <= clock)
                    {
                        camflipimage = Form1.cameraflipupimage1;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 2)
                    {
                        camflipimage = Form1.cameraflipupimage2;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 3)
                    {
                        camflipimage = Form1.cameraflipupimage3;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 4)
                    {
                        camflipimage = Form1.cameraflipupimage4;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 5)
                    {
                        camflipimage = Form1.cameraflipupimage5;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 6)
                    {
                        camflipimage = Form1.cameraflipupimage6;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 7)
                    {
                        camflipimage = Form1.cameraflipupimage7;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 8)
                    {
                        camflipimage = Form1.cameraflipupimage8;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 9)
                    {
                        camflipimage = Form1.cameraflipupimage9;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 10)
                    {
                        camflipimage = Form1.cameraflipupimage10;
                    }
                    else if (camtimer.ElapsedMilliseconds >= clock * 11)
                    {
                        camflipimage = Form1.cameraflipupimage11;
                        camscreen = true;
                        camtimer.Reset();
                    }
                }
            }
            else if (camscreen == true)
            {
                if (camtimer.IsRunning)
                {
                    officescreen = true;
                    if (camtimer.ElapsedMilliseconds <= clock)
                    {
                        camflipimage = Form1.cameraflipupimage11;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 2)
                    {
                        camflipimage = Form1.cameraflipupimage10;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 3)
                    {
                        camflipimage = Form1.cameraflipupimage9;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 4)
                    {
                        camflipimage = Form1.cameraflipupimage8;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 5)
                    {
                        camflipimage = Form1.cameraflipupimage7;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 6)
                    {
                        camflipimage = Form1.cameraflipupimage6;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 7)
                    {
                        camflipimage = Form1.cameraflipupimage5;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 8)
                    {
                        camflipimage = Form1.cameraflipupimage4;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 9)
                    {
                        camflipimage = Form1.cameraflipupimage3;
                    }
                    else if (camtimer.ElapsedMilliseconds <= clock * 10)
                    {
                        camflipimage = Form1.cameraflipupimage2;
                    }
                    else if (camtimer.ElapsedMilliseconds >= clock * 11)
                    {
                        camflipimage = Form1.cameraflipupimage1;
                        camscreen = false;
                        camtimer.Reset();
                        camflip.Stop();
                    }
                }
            }
            Refresh();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameoverbool == false)
            {
                freddieobj.move(freddie);
                chikaobj.move(chika);
                bonnyobj.move(bonny);

                #region move background
                if (officescreen == true)
                {
                    if (MousePosition.X > Form1.sizex / 2 + Form1.sizex / 16 && backrec.X + backrec.Width > this.Width)
                    {
                        backrec.X -= 12;
                        leftbuttonrec.X -= 12;
                        rightbuttonrec.X -= 12;
                        leftdoorrec.X -= 12;
                        rightdoorrec.X -= 12;
                    }
                    if (MousePosition.X < Form1.sizex / 2 - Form1.sizex / 16 && backrec.X < 0)
                    {
                        backrec.X += 12;
                        leftbuttonrec.X += 12;
                        rightbuttonrec.X += 12;
                        leftdoorrec.X += 12;
                        rightdoorrec.X += 12;
                    }
                }
                else if (camscreen == true)
                {
                    if (backrec.X >= Form1.sizex / 307)
                    {
                        camright = false;
                    }
                    else if (backrec.X + backrec.Width <= Form1.sizex - Form1.sizex / 307)
                    {
                        camright = true;
                    }
                    if (camright == false)
                    {
                        backrec.X -= 1;
                        leftbuttonrec.X -= 1;
                        rightbuttonrec.X -= 1;
                        leftdoorrec.X -= 1;
                        rightdoorrec.X -= 1;
                    }
                    else if (camright == true)
                    {
                        backrec.X += 1;
                        leftbuttonrec.X += 1;
                        rightbuttonrec.X += 1;
                        leftdoorrec.X += 1;
                        rightdoorrec.X += 1;
                    }
                }
                if (backrec.X + backrec.Width < Form1.sizex * -1)
                {
                    backrec.X = Form1.sizex + backrec.Width;
                }
                if (backrec.X > 0)
                {
                    backrec.X = 0;
                    camright = false;
                }
                #endregion
                // make camera button show up and go away 
                #region camerabutton movement
                if (camscreen == true && officescreen == true)
                {
                    cameraButton.Visible = false;
                    cameraButton.Enabled = false;
                }
                else if (camscreen == true || officescreen == true)
                {
                    cameraButton.Enabled = true;
                    cameraButton.Visible = true;
                }
                else
                {
                    cameraButton.Visible = false;
                    cameraButton.Enabled = false;
                }
                #endregion
                // set camera screens
                #region camera screens
                if (camscreen == true)
                {
                    background = camera;
                    cam1Abutton.Visible = true;
                    cam1Bbutton.Visible = true;
                    cam1Cbutton.Visible = true;
                    cam2Abutton.Visible = true;
                    cam2Bbutton.Visible = true;
                    cam3button.Visible = true;
                    cam4Abutton.Visible = true;
                    cam4Bbutton.Visible = true;
                    cam5button.Visible = true;
                    cam6button.Visible = true;
                    cam7button.Visible = true;

                    // 1 = 1A
                    // 2 = 1B
                    // 3 = 1C
                    // 4 = 2B
                    // 5 = 3
                    // 6 = 4a
                    // 7 = 4B
                    // 8 = 5
                    // 9 = 7
                    // 10 = 2A
                    switch (camnumber)
                    {
                        case 1: // cam 1A
                            if (bonny == 1 && freddie == 1 && chika == 1)
                            {
                                camera = Form1.cam1Aall;
                            }
                            else if (bonny == 1 && freddie == 1 && chika != 1)
                            {
                                camera = Form1.cam1AFB;
                            }
                            else if (freddie == 1 && chika != 1 && bonny != 1)
                            {
                                camera = Form1.cam1AF;
                            }
                            else if (freddie == 1 && chika == 1 && bonny != 1)
                            {
                                camera = Form1.cam1AFC;
                            }
                            else
                            {
                                camera = Form1.cam1Anone;
                            }
                            break;
                        case 2: //cam 1B
                            if (bonny == 2)
                            {
                                camera = Form1.cam1BB;
                            }
                            else if (freddie == 2)
                            {
                                camera = Form1.cam1BF;
                            }
                            else if (chika == 2)
                            {
                                camera = Form1.cam1BC;
                            }
                            else
                            {
                                camera = Form1.cam1Bnone;
                            }
                            break;
                        case 3: //cam 1C
                            if (foxie == 1)
                            {
                                camera = Form1.cam1C1;
                            }
                            else if (foxie == 2)
                            {
                                camera = Form1.cam1C2;
                            }
                            else if (foxie == 3)
                            {
                                camera = Form1.cam1C3;
                            }
                            else if (foxie == 4)
                            {
                                camera = Form1.cam1C4;
                            }
                            else
                            {
                                camera = Form1.cam1C5;
                            }
                            break;
                        case 4: // cam 2b
                            if (bonny == 4)
                            {
                                camera = Form1.cam2BB;
                            }
                            else
                            {
                                camera = Form1.cam2Bnone;
                            }
                            break;
                        case 5: //cam 3
                            if (bonny == 5)
                            {
                                camera = Form1.cam3B;
                            }
                            else
                            {
                                camera = Form1.cam3none;
                            }
                            break;
                        case 6: //cam 4a
                            if (chika == 6)
                            {
                                camera = Form1.cam4AC;
                            }
                            else if (freddie == 6)
                            {
                                camera = Form1.cam4AF;
                            }
                            else
                            {
                                camera = Form1.cam4Anone;
                            }
                            break;
                        case 7: //cam4B
                            if (chika == 7)
                            {
                                camera = Form1.cam4BC;
                            }
                            else if (freddie == 7)
                            {
                                camera = Form1.cam4BF;
                            }
                            else
                            {
                                camera = Form1.cam4Bnone;
                            }
                            break;
                        case 8://cam 5
                            if (bonny == 8)
                            {
                                camera = Form1.cam5B;
                            }
                            else
                            {
                                camera = Form1.cam5none;
                            }
                            break;
                        case 9://cam 7
                            if (chika == 9)
                            {
                                camera = Form1.cam7C;
                            }
                            else if (freddie == 9)
                            {
                                camera = Form1.cam7F;
                            }
                            else
                            {
                                camera = Form1.cam7none;
                            }
                            break;
                        case 10://cam 2a
                            if (foxie == 10)
                            {

                            }
                            else if (bonny == 10)
                            {
                                camera = Form1.cam2Abonny;
                            }
                            else
                            {

                                camera = Properties.Resources.foxy_running_3;
                            }
                            break;
                        case 11:
                            //play audio
                            break;
                    }
                }
                #endregion
                // office background
                #region office
                else if (camscreen == false)
                {
                    if (leftlight == true && bonny == 0)
                    {
                        background = Form1.officeB;
                    }
                    else if (rightlight == true && chika == 0)
                    {
                        background = Form1.officeC;
                    }
                    else if (leftlight == true && bonny != 0)
                    {
                        background = Form1.officeLL;
                    }
                    else if (rightlight == true && chika != 0)
                    {
                        background = Form1.officeLR;
                    }
                    else
                    {
                        background = Form1.office;
                    }
                    cam1Abutton.Visible = false;
                    cam1Bbutton.Visible = false;
                    cam1Cbutton.Visible = false;
                    cam2Abutton.Visible = false;
                    cam2Bbutton.Visible = false;
                    cam3button.Visible = false;
                    cam4Abutton.Visible = false;
                    cam4Bbutton.Visible = false;
                    cam5button.Visible = false;
                    cam6button.Visible = false;
                    cam7button.Visible = false;
                }
                #endregion
                // set doors
                #region doors
                if (leftdoor == true && leftdoorimage != Form1.leftdoor14)
                {
                    leftdoortimer.Start();
                    if (leftdoortimer.ElapsedMilliseconds <= time)
                    {
                        leftdoorimage = Form1.leftdoor1;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 2)
                    {
                        leftdoorimage = Form1.leftdoor2;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 3)
                    {
                        leftdoorimage = Form1.leftdoor3;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 4)
                    {
                        leftdoorimage = Form1.leftdoor4;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 5)
                    {
                        leftdoorimage = Form1.leftdoor5;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 6)
                    {
                        leftdoorimage = Form1.leftdoor6;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 7)
                    {
                        leftdoorimage = Form1.leftdoor7;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 8)
                    {
                        leftdoorimage = Form1.leftdoor8;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 9)
                    {
                        leftdoorimage = Form1.leftdoor9;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 10)
                    {
                        leftdoorimage = Form1.leftdoor10;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 11)
                    {
                        leftdoorimage = Form1.leftdoor11;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 12)
                    {
                        leftdoorimage = Form1.leftdoor12;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 13)
                    {
                        leftdoorimage = Form1.leftdoor13;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds >= time * 14)
                    {
                        leftdoorimage = Form1.leftdoor14;
                        leftdoordown = true;
                        leftdoortimer.Reset();
                    }
                }//left door down
                else if (leftdoor == false && leftdoorimage != Form1.leftdoor1)
                {
                    leftdoortimer.Start();
                    if (leftdoortimer.ElapsedMilliseconds <= time)
                    {
                        leftdoorimage = Form1.leftdoor14;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 2)
                    {
                        leftdoorimage = Form1.leftdoor13;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 3)
                    {
                        leftdoorimage = Form1.leftdoor12;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 4)
                    {
                        leftdoorimage = Form1.leftdoor11;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 5)
                    {
                        leftdoorimage = Form1.leftdoor10;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 6)
                    {
                        leftdoorimage = Form1.leftdoor9;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 7)
                    {
                        leftdoorimage = Form1.leftdoor8;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 8)
                    {
                        leftdoorimage = Form1.leftdoor7;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 9)
                    {
                        leftdoorimage = Form1.leftdoor6;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 10)
                    {
                        leftdoorimage = Form1.leftdoor5;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 11)
                    {
                        leftdoorimage = Form1.leftdoor4;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 12)
                    {
                        leftdoorimage = Form1.leftdoor3;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds <= time * 13)
                    {
                        leftdoorimage = Form1.leftdoor2;
                    }
                    else if (leftdoortimer.ElapsedMilliseconds >= time * 14)
                    {
                        leftdoorimage = Form1.leftdoor1;
                        leftdoordown = false;
                        leftdoortimer.Reset();
                    }
                }//left door up
                if (rightdoor == true && rightdoorimage != Form1.rightdoor14)
                {
                    rightdoortimer.Start();
                    if (rightdoortimer.ElapsedMilliseconds <= time)
                    {
                        rightdoorimage = Form1.rightdoor1;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 2)
                    {
                        rightdoorimage = Form1.rightdoor2;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 3)
                    {
                        rightdoorimage = Form1.rightdoor3;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 4)
                    {
                        rightdoorimage = Form1.rightdoor4;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 5)
                    {
                        rightdoorimage = Form1.rightdoor5;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 6)
                    {
                        rightdoorimage = Form1.rightdoor6;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 7)
                    {
                        rightdoorimage = Form1.rightdoor7;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 8)
                    {
                        rightdoorimage = Form1.rightdoor8;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 9)
                    {
                        rightdoorimage = Form1.rightdoor9;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 10)
                    {
                        rightdoorimage = Form1.rightdoor10;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 11)
                    {
                        rightdoorimage = Form1.rightdoor11;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 12)
                    {
                        rightdoorimage = Form1.rightdoor12;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 13)
                    {
                        rightdoorimage = Form1.rightdoor13;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds >= time * 14)
                    {
                        rightdoorimage = Form1.rightdoor14;
                        rightdoordown = true;
                        rightdoortimer.Reset();
                    }
                }//right door down
                else if (rightdoor == false && rightdoorimage != Form1.rightdoor1)
                {
                    rightdoortimer.Start();
                    if (rightdoortimer.ElapsedMilliseconds <= time)
                    {
                        rightdoorimage = Form1.rightdoor14;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 2)
                    {
                        rightdoorimage = Form1.rightdoor13;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 3)
                    {
                        rightdoorimage = Form1.rightdoor12;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 4)
                    {
                        rightdoorimage = Form1.rightdoor11;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 5)
                    {
                        rightdoorimage = Form1.rightdoor10;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 6)
                    {
                        rightdoorimage = Form1.rightdoor9;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 7)
                    {
                        rightdoorimage = Form1.rightdoor8;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 8)
                    {
                        rightdoorimage = Form1.rightdoor7;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 9)
                    {
                        rightdoorimage = Form1.rightdoor6;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 10)
                    {
                        rightdoorimage = Form1.rightdoor5;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 11)
                    {
                        rightdoorimage = Form1.rightdoor4;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 12)
                    {
                        rightdoorimage = Form1.rightdoor3;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds <= time * 13)
                    {
                        rightdoorimage = Form1.rightdoor2;
                    }
                    else if (rightdoortimer.ElapsedMilliseconds >= time * 14)
                    {
                        rightdoorimage = Form1.rightdoor1;
                        rightdoordown = false;
                        rightdoortimer.Reset();
                    }
                } //right door up
                if (leftdoortimer.IsRunning == false && leftdoordown == false)
                {
                    leftdoorimage = Form1.leftdoor1;
                }
                if (leftdoortimer.IsRunning == false && leftdoordown == true)
                {
                    leftdoorimage = Form1.leftdoor14;
                }
                if (leftdoordown == true && bonny == 0)
                {

                }
                #endregion
                // set buttons
                #region buttons
                if (leftlight == true && leftdoor == false)
                {
                    leftbutton = Form1.leftbuttonlight;
                }
                else if (leftlight == true && leftdoor == true)
                {
                    leftbutton = Form1.leftbuttonson;
                }
                else if (leftlight == false && leftdoor == true)
                {
                    leftbutton = Form1.leftbuttondoor;
                }
                else
                {
                    leftbutton = Form1.leftbuttonsoff;
                }
                if (rightlight == true && rightdoor == false)
                {
                    rightbutton = Form1.rightbuttonlight;
                }
                else if (rightlight == true && rightdoor == true)
                {
                    rightbutton = Form1.rightbuttonson;
                }
                else if (rightlight == false && rightdoor == true)
                {
                    rightbutton = Form1.rightbuttondoor;
                }
                else
                {
                    rightbutton = Form1.rightbuttonsoff;
                }
                #endregion
                // gameover commands
            }
            // animatronics animations
            if (bonny == 0 && leftdoordown == false)
            {
                bonnywatch.Start();
                if (bonnywatch.ElapsedMilliseconds >= 3000 && count != 5)
                {
                    stopwatch.Start();
                    gameoverbool = true;
                    if (stopwatch.ElapsedMilliseconds <= time)
                    {
                        background = Form1.bonnyscare1;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 2)
                    {
                        background = Form1.bonnyscare2;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 3)
                    {
                        background = Form1.bonnyscare3;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 4)
                    {
                        background = Form1.bonnyscare4;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 5)
                    {
                        background = Form1.bonnyscare5;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 6)
                    {
                        background = Form1.bonnyscare6;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 7)
                    {
                        background = Form1.bonnyscare7;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 8)
                    {
                        background = Form1.bonnyscare8;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 9)
                    {
                        background = Form1.bonnyscare9;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 10)
                    {
                        background = Form1.bonnyscare8;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 11)
                    {
                        background = Form1.bonnyscare7;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 12)
                    {
                        background = Form1.bonnyscare6;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 13)
                    {
                        background = Form1.bonnyscare5;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 14)
                    {
                        background = Form1.bonnyscare4;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 15)
                    {
                        background = Form1.bonnyscare3;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 16)
                    {
                        background = Form1.bonnyscare2;
                    }
                    else if (stopwatch.ElapsedMilliseconds >= time * 17)
                    {
                        background = Form1.bonnyscare1;
                        count++;
                        stopwatch.Reset();
                    }
                }
                else if (count == 5)
                {
                    bonny = 30;
                    gameover();
                }
            }
            else if (leftdoordown == true && bonny == 0)
            {
                bonny = 1;
            }
            if (chika == 0)
            {
                chikawatch.Start();
                if (chikawatch.ElapsedMilliseconds >= 3000 && count != 3)
                {
                    stopwatch.Start();
                    gameoverbool = true;
                    if (stopwatch.ElapsedMilliseconds <= time)
                    {
                        background = Form1.chikascare1;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 2)
                    {
                        background = Form1.chikascare2;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 3)
                    {
                        background = Form1.chikascare3;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 4)
                    {
                        background = Form1.chikascare4;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 5)
                    {
                        background = Form1.chikascare5;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 6)
                    {
                        background = Form1.chikascare6;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 7)
                    {
                        background = Form1.chikascare7;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 8)
                    {
                        background = Form1.chikascare8;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 9)
                    {
                        background = Form1.chikascare9;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 10)
                    {
                        background = Form1.chikascare10;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 11)
                    {
                        background = Form1.chikascare11;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 12)
                    {
                        background = Form1.chikascare12;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 13)
                    {
                        background = Form1.chikascare13;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 14)
                    {
                        background = Form1.chikascare14;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 15)
                    {
                        background = Form1.chikascare15;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 16)
                    {
                        background = Form1.chikascare16;
                        count++;
                        stopwatch.Reset();
                    }
                }
                else if (count == 3)
                {
                    chika = 30;
                    gameover();
                }
            }
            else if (rightdoordown == true && chika == 0)
            {
                bonny = 1;
            }
            if (freddie == 0)
            {
                freddiewatch.Start();
                if (freddiewatch.ElapsedMilliseconds >= 3000 && count != 2)
                {
                    stopwatch.Start();
                    gameoverbool = true;
                    if (stopwatch.ElapsedMilliseconds <= time)
                    {
                        background = Form1.freddiescare1;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 2)
                    {
                        background = Form1.freddiescare2;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 3)
                    {
                        background = Form1.freddiescare3;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 4)
                    {
                        background = Form1.freddiescare4;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 5)
                    {
                        background = Form1.freddiescare5;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 6)
                    {
                        background = Form1.freddiescare6;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 7)
                    {
                        background = Form1.freddiescare7;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 8)
                    {
                        background = Form1.freddiescare8;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 9)
                    {
                        background = Form1.freddiescare9;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 10)
                    {
                        background = Form1.freddiescare10;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 11)
                    {
                        background = Form1.freddiescare11;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 12)
                    {
                        background = Form1.freddiescare12;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 13)
                    {
                        background = Form1.freddiescare13;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 14)
                    {
                        background = Form1.freddiescare14;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 15)
                    {
                        background = Form1.freddiescare15;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 16)
                    {
                        background = Form1.freddiescare16;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 17)
                    {
                        background = Form1.freddiescare17;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 18)
                    {
                        background = Form1.freddiescare18;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 19)
                    {
                        background = Form1.freddiescare19;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 20)
                    {
                        background = Form1.freddiescare20;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 21)
                    {
                        background = Form1.freddiescare21;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 22)
                    {
                        background = Form1.freddiescare22;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 23)
                    {
                        background = Form1.freddiescare23;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 24)
                    {
                        background = Form1.freddiescare24;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 25)
                    {
                        background = Form1.freddiescare25;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 26)
                    {
                        background = Form1.freddiescare26;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 27)
                    {
                        background = Form1.freddiescare27;
                    }
                    else if (stopwatch.ElapsedMilliseconds <= time * 28)
                    {
                        background = Form1.freddiescare28;
                        count++;
                        stopwatch.Reset();
                    }
                }
                else if (count == 2)
                {
                    freddie = 30;
                    gameover();
                }
            }
            if (gameoverlabel.Visible == true)
            {
                endwatch.Start();
                if (stopwatch.ElapsedMilliseconds <= 5000)
                {
                    Form1.ChangeScreen(this, new Main_Menu());
                }
            }
            Refresh();
        }
        private void cameraButton_MouseEnter(object sender, EventArgs e)
        {
            camflip.Start();
            camtimer.Start();
        }
        private void Game_screen_Paint(object sender, PaintEventArgs e)
        {
            if (gameoverbool == false)
            {
                if (background == null)
                {
                    background = Form1.office;
                }
                e.Graphics.DrawImage(background, backrec);
                if (camscreen == false || officescreen == true)
                {
                    e.Graphics.DrawImage(leftbutton, leftbuttonrec);
                    e.Graphics.DrawImage(rightbutton, rightbuttonrec);
                    e.Graphics.DrawImage(leftdoorimage, leftdoorrec);
                    e.Graphics.DrawImage(rightdoorimage, rightdoorrec);
                }
                if (camtimer.IsRunning)
                {
                    e.Graphics.DrawImage(camflipimage, 0, 0);
                }
                if (camscreen == true)
                {
                    e.Graphics.DrawImage(Form1.cammap, Form1.sizex - Form1.cammap.Width, Form1.sizey - Form1.cammap.Height);
                }
            }
            else
            {
                e.Graphics.DrawImage(background, backrec);
                if (count == 5)
                {
                    e.Graphics.DrawImage(background, 0, 0, Form1.sizex, Form1.sizey);
                }
            }
        }
        private void gameover()
        {
            gameoverlabel.Visible = true;
            cameraButton.Visible = false;
            cameraButton.Enabled = false;
            rightlightbutton.Visible = false;
            rightlightbutton.Enabled = false;
            rightdoorbutton.Visible = false;
            rightdoorbutton.Enabled = false;
            leftlightbutton.Visible = false;
            leftlightbutton.Enabled = false;
            leftdoorbutton.Enabled = false;
            leftdoorbutton.Visible = false;

            gameoverlabel.Visible = true;
            gameoverlabel.Location = new Point(Form1.sizex / 128 * 90, Form1.sizey / 128 * 110);

            background = Form1.deathscreen;
        }

        private void leftlightbutton_Click(object sender, EventArgs e)
        {
            click1++;
            if (click1 % 2 == 0)
            {
                leftlight = true;
                if (rightlight == true)
                {
                    rightlight = false;
                }
            }
            else
            {
                leftlight = false;
            }
        }
        private void rightlightbutton_Click(object sender, EventArgs e)
        {
            click2++;
            if (click2 % 2 == 0)
            {
                rightlight = true;
                if (leftlight == true)
                {
                    leftlight = false;
                }
            }
            else
            {
                rightlight = false;
            }
        }
        private void leftdoorbutton_Click(object sender, EventArgs e)
        {
            click3++;
            if (click3 % 2 == 0)
            {
                leftdoor = true;
            }
            else
            {
                leftdoor = false;
            }
        }
        private void rightdoorbutton_Click(object sender, EventArgs e)
        {
            click4++;
            if (click4 % 2 == 0)
            {
                rightdoor = true;
            }
            else
            {
                rightdoor = false;
            }
        }

        #region camera buttons
        private void cam1Abutton_Click(object sender, EventArgs e)
        {
            camnumber = 1;
        }
        private void cam1Bbutton_Click(object sender, EventArgs e)
        {
            camnumber = 2;
        }
        private void cam1Cbutton_Click(object sender, EventArgs e)
        {
            camnumber = 3;
        }
        private void cam2Abutton_Click(object sender, EventArgs e)
        {
            camnumber = 10;
        }
        private void cam2Bbutton_Click(object sender, EventArgs e)
        {
            camnumber = 4;
        }
        private void cam3button_Click(object sender, EventArgs e)
        {
            camnumber = 5;
        }
        private void cam4Abutton_Click(object sender, EventArgs e)
        {
            camnumber = 6;
        }
        private void cam4Bbutton_Click(object sender, EventArgs e)
        {
            camnumber = 7;
        }
        private void cam5button_Click(object sender, EventArgs e)
        {
            camnumber = 8;
        }
        private void cam6button_Click(object sender, EventArgs e)
        {

        }
        private void cam7button_Click(object sender, EventArgs e)
        {
            camnumber = 9;
        }
        #endregion
    }
}
