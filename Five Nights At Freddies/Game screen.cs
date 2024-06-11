using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Game_screen : UserControl
    {

        public static Stopwatch camtimer = new Stopwatch();

        int clock = 40;

        bool camscreen;

        int camnumber, bonnie, freddie, chika, foxie;

        Bitmap camflipimage = new Bitmap(Form1.cameraflipupimage1, new Size(Form1.sizex, Form1.sizey));
        Bitmap officeimage = new Bitmap(Form1.office, new Size((Form1.sizex / 4) * 6, Form1.sizey));
        Bitmap cambuttonimage = new Bitmap(Properties.Resources.camerabuttonimage, new Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32));



        Image camera;

        public Game_screen()
        {
            InitializeComponent();
            gameTimer.Start();
            this.BackgroundImage = officeimage;
            cameraButton.BackColor = Color.Transparent;

            cameraButton.BackgroundImage = cambuttonimage;
            cameraButton.Size = new System.Drawing.Size(Form1.sizex / 3 * 2, Form1.sizey / 16 + Form1.sizey / 32);
            cameraButton.Location = new System.Drawing.Point(Form1.sizex / 16 * 3, Form1.sizey - cameraButton.Height);
            cameraButton.Enabled = true;

            leftsidelabel.Location = new Point(0, 0);
            leftsidelabel.Size = new Size(Form1.sizex / 3, Form1.sizey);
            leftsidelabel.BackColor = Color.Transparent;
            leftsidelabel.Text = "";

            rightsidelabel.Location = new Point(Form1.sizex / 3 + Form1.sizex / 3, 0);
            rightsidelabel.Size = new Size(Form1.sizex / 3, Form1.sizey);
            rightsidelabel.BackColor = Color.Transparent;
            rightsidelabel.Text = "";

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

            cam1Abutton.BringToFront();
            cam1Bbutton.BringToFront();
            cam1Cbutton.BringToFront();
            cam2Abutton.BringToFront();
            cam2Bbutton.BringToFront();
            cam3button.BringToFront();
            cam4Abutton.BringToFront();
            cam4Bbutton.BringToFront();
            cam5button.BringToFront();
            cam6button.BringToFront();
            cam7button.BringToFront();

            cam1Abutton.Location = new Point(Form1.sizex / 8 /*((Form1.sizex / 4) * 3)*/ , Form1.sizey);
            cam1Bbutton.BringToFront();
            cam1Cbutton.BringToFront();
            cam2Abutton.BringToFront();
            cam2Bbutton.BringToFront();
            cam3button.BringToFront();
            cam4Abutton.BringToFront();
            cam4Bbutton.BringToFront();
            cam5button.BringToFront();
            cam6button.BringToFront();
            cam7button.BringToFront();
        }
        private void camflip_Tick(object sender, EventArgs e)
        {
            if (camtimer.IsRunning)
            {
                if (camtimer.ElapsedMilliseconds <= clock)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage1, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 2)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage2, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 3)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage3, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 4)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage4, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 5)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage5, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 6)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage6, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 7)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage7, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 8)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage8, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 9)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage9, new Size(Form1.sizex, Form1.sizey));
                    camscreen = true;
                }
                else if (camtimer.ElapsedMilliseconds <= clock * 10)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage10, new Size(Form1.sizex, Form1.sizey));
                }
                else if (camtimer.ElapsedMilliseconds >= clock * 11)
                {
                    camflipimage = new Bitmap(Form1.cameraflipupimage11, new Size(Form1.sizex, Form1.sizey));
                    camscreen = true;
                    camtimer.Reset();
                }
            }
            Refresh();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            leftsidelabel.Text = camscreen.ToString();
            leftsidelabel.Visible = true;
            leftsidelabel.BringToFront();
            camnumber = 1;
            switch (camnumber)
            {
                case 1: // cam 1A
                    if (bonnie == 1 && freddie == 1 && chika == 1)
                    {
                        camera = Form1.cam1Aall;
                    }
                    else if (bonnie == 1 && freddie == 1)
                    {
                        camera = Form1.cam1AFB;
                    }
                    else if (freddie == 1)
                    {
                        camera = Form1.cam1AF;
                    }
                    else if (freddie == 1 && chika == 1)
                    {
                        camera = Form1.cam1AFC;
                    }
                    else
                    {
                        camera = Form1.cam1Anone;
                    }
                    break;
                case 2: //cam 1B
                    if (bonnie == 2)
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
                    break; // cam 2b
                case 4:
                    if (bonnie == 4)
                    {
                        camera = Form1.cam2BB;
                    }
                    else
                    {
                        camera = Form1.cam2Bnone;
                    }
                    break;
                case 5: //cam 3
                    if (bonnie == 5)
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
                    if (bonnie == 8)
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
                    break;
            }
            if (camscreen == true)
            {
                this.BackgroundImage = camera;
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

                cam1Abutton.BringToFront();
            }
            Refresh();
        }
        private void cameraButton_MouseEnter(object sender, EventArgs e)
        {
            cameraButton.Enabled = false;
            cameraButton.Visible = false;
            camflip.Start();
            camtimer.Start();
        }
        private void leftsidelabel_MouseEnter(object sender, EventArgs e)
        {

        }
        private void rightsidelabel_MouseEnter(object sender, EventArgs e)
        {

        }
        private void cameraButton_MouseLeave(object sender, EventArgs e)
        {
            if (camscreen == true)
            {
                cameraButton.Enabled = true;
                cameraButton.Visible = true;
                cameraButton.BringToFront();
            }
        }
        private void Game_screen_Paint(object sender, PaintEventArgs e)
        {
            if (camtimer.IsRunning)
            {
                e.Graphics.DrawImage(camflipimage, 0, 0);
            }
            if (camscreen == true)
            {
                e.Graphics.DrawImage(Form1.cammap, Form1.sizex - Form1.cammap.Width, Form1.sizey - Form1.cammap.Height);
            }
        }
    }
}
