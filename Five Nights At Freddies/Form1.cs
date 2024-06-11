using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Form1 : Form
    {
        public static int sizex, sizey;

        public static Image cammap = Properties.Resources.cammap;
        public static Image mainmenu1 = Properties.Resources.fnaf_1_1;
        public static Image mainmenu2 = Properties.Resources.fnaf_1_2;
        public static Image mainmenu3 = Properties.Resources.fnaf_1_3;
        public static Image mainmenu4 = Properties.Resources.fnaf_1_4;

        public static Image staticimage1 = Properties.Resources.static_1;
        public static Image staticimage2 = Properties.Resources.static_2;
        public static Image staticimage3 = Properties.Resources.static_3;
        public static Image staticimage4 = Properties.Resources.static_4;
        public static Image staticimage5 = Properties.Resources.static_5;
        public static Image staticimage6 = Properties.Resources.static_6;
        public static Image staticimage7 = Properties.Resources.static_7;

        public static Image cameraflipupimage1 = Properties.Resources.camflip_1;
        public static Image cameraflipupimage2 = Properties.Resources.camflip_2;
        public static Image cameraflipupimage3 = Properties.Resources.camflip_3;
        public static Image cameraflipupimage4 = Properties.Resources.camflip_4;
        public static Image cameraflipupimage5 = Properties.Resources.camflip_5;
        public static Image cameraflipupimage6 = Properties.Resources.camflip_6;
        public static Image cameraflipupimage7 = Properties.Resources.camflip_7;
        public static Image cameraflipupimage8 = Properties.Resources.camflip_8;
        public static Image cameraflipupimage9 = Properties.Resources.camflip_9;
        public static Image cameraflipupimage10 = Properties.Resources.camflip_10;
        public static Image cameraflipupimage11 = Properties.Resources.camflip_11;

        public static Image office = Properties.Resources.office_empty;

        public static Image cam1Anone = Properties.Resources._1A_all;
        public static Image cam1Aall = Properties.Resources._1A_none;
        public static Image cam1AFC = Properties.Resources._1A_bonnie;
        public static Image cam1AFB = Properties.Resources._1A_chika;
        public static Image cam1AF = Properties.Resources._1A_bonnie_and_chika;

        public static Image cam1Bnone = Properties.Resources._1B_none;
        public static Image cam1BC = Properties.Resources._1B_chika;
        public static Image cam1BF = Properties.Resources._1B_freddie;
        public static Image cam1BB = Properties.Resources._1B_bonnie;

        public static Image cam1C1 = Properties.Resources._1C_1;
        public static Image cam1C2 = Properties.Resources._1C_2;
        public static Image cam1C3 = Properties.Resources._1C_3;
        public static Image cam1C4 = Properties.Resources._1C_4;
        public static Image cam1C5 = Properties.Resources._1C_5;

        public static Image cam2Bnone = Properties.Resources._2B_none;
        public static Image cam2BB = Properties.Resources._2B_bonnie;

        public static Image cam3none = Properties.Resources._3_none;
        public static Image cam3B = Properties.Resources._3_bonnie;

        public static Image cam4Anone = Properties.Resources._4Anone;
        public static Image cam4AC = Properties.Resources._4A_chika;
        public static Image cam4AF = Properties.Resources._4A_freddie;

        public static Image cam4Bnone = Properties.Resources._4B_none;
        public static Image cam4BF = Properties.Resources._4B_freddie;
        public static Image cam4BC = Properties.Resources._4B_chika;

        public static Image cam5none = Properties.Resources._5_none;
        public static Image cam5B = Properties.Resources._5_bonnie;

        public static Image cam7none = Properties.Resources._7none;
        public static Image cam7C = Properties.Resources._7_chika;
        public static Image cam7F = Properties.Resources._7_freddie;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    Close();
                    break;
            }
        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;

                f = current.FindForm();

                f.Controls.Remove(current);
            }

            f.Controls.Add(next);
            next.Size = new System.Drawing.Size(sizex, sizey);
            next.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.KeyPreview = true;
            WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            sizex = this.Size.Width;
            sizey = this.Size.Height;
            Form1.ChangeScreen(this, new Main_Menu());
        }
    }
}
