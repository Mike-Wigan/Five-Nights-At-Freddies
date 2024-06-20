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
        #region delering stuff
        public static int sizex, sizey;

        public static Bitmap deathscreen = Properties.Resources.fnaf_1_death;
        public static Bitmap cammap = Properties.Resources.cammap;
        public static Bitmap mainmenu1 = Properties.Resources.fnaf_1_1;
        public static Bitmap mainmenu2 = Properties.Resources.fnaf_1_2;
        public static Bitmap mainmenu3 = Properties.Resources.fnaf_1_3;
        public static Bitmap mainmenu4 = Properties.Resources.fnaf_1_4;

        public static Bitmap staticimage1 = Properties.Resources.static_1;
        public static Bitmap staticimage2 = Properties.Resources.static_2;
        public static Bitmap staticimage3 = Properties.Resources.static_3;
        public static Bitmap staticimage4 = Properties.Resources.static_4;
        public static Bitmap staticimage5 = Properties.Resources.static_5;
        public static Bitmap staticimage6 = Properties.Resources.static_6;
        public static Bitmap staticimage7 = Properties.Resources.static_7;

        public static Bitmap cameraflipupimage1 = Properties.Resources.camflip_1;
        public static Bitmap cameraflipupimage2 = Properties.Resources.camflip_2;
        public static Bitmap cameraflipupimage3 = Properties.Resources.camflip_3;
        public static Bitmap cameraflipupimage4 = Properties.Resources.camflip_4;
        public static Bitmap cameraflipupimage5 = Properties.Resources.camflip_5;
        public static Bitmap cameraflipupimage6 = Properties.Resources.camflip_6;
        public static Bitmap cameraflipupimage7 = Properties.Resources.camflip_7;
        public static Bitmap cameraflipupimage8 = Properties.Resources.camflip_8;
        public static Bitmap cameraflipupimage9 = Properties.Resources.camflip_9;
        public static Bitmap cameraflipupimage10 = Properties.Resources.camflip_10;
        public static Bitmap cameraflipupimage11 = Properties.Resources.camflip_11;

        public static Bitmap office = Properties.Resources.office_empty;
        public static Bitmap officeB = Properties.Resources.office_bonnie;
        public static Bitmap officeC = Properties.Resources.office_chika;
        public static Bitmap officeF = Properties.Resources.office_freddie;
        public static Bitmap officeLR = Properties.Resources.office_right_light;
        public static Bitmap officeLO = Properties.Resources.office_lights_off;
        public static Bitmap officeLL = Properties.Resources.office_left_light;

        public static Bitmap cam1Anone = Properties.Resources._1A_all;
        public static Bitmap cam1Aall = Properties.Resources._1A_none;
        public static Bitmap cam1AFC = Properties.Resources._1A_bonnie;
        public static Bitmap cam1AFB = Properties.Resources._1A_chika;
        public static Bitmap cam1AF = Properties.Resources._1A_bonnie_and_chika;

        public static Bitmap cam1Bnone = Properties.Resources._1B_none;
        public static Bitmap cam1BC = Properties.Resources._1B_chika;
        public static Bitmap cam1BF = Properties.Resources._1B_freddie;
        public static Bitmap cam1BB = Properties.Resources._1B_bonnie;

        public static Bitmap cam1C1 = Properties.Resources._1C_1;
        public static Bitmap cam1C2 = Properties.Resources._1C_2;
        public static Bitmap cam1C3 = Properties.Resources._1C_3;
        public static Bitmap cam1C4 = Properties.Resources._1C_4;
        public static Bitmap cam1C5 = Properties.Resources._1C_5;

        public static Bitmap cam2Abonny = Properties.Resources.foxy_running_5;
        public static Bitmap cam2A1 = Properties.Resources.foxy_running_6;
        public static Bitmap cam2A2 = Properties.Resources.foxy_running_7;
        public static Bitmap cam2A3 = Properties.Resources.foxy_running_8;
        public static Bitmap cam2A4 = Properties.Resources.foxy_running_9;
        public static Bitmap cam2A5 = Properties.Resources.foxy_running_10;
        public static Bitmap cam2A6 = Properties.Resources.foxy_running_11;
        public static Bitmap cam2A7 = Properties.Resources.foxy_running_12;
        public static Bitmap cam2A8 = Properties.Resources.foxy_running_13;
        public static Bitmap cam2A9 = Properties.Resources.foxy_running_14;
        public static Bitmap cam2A10 = Properties.Resources.foxy_running_15;
        public static Bitmap cam2A11 = Properties.Resources.foxy_running_16;
        public static Bitmap cam2A12 = Properties.Resources.foxy_running_17;
        public static Bitmap cam2A13 = Properties.Resources.foxy_running_18;
        public static Bitmap cam2A14 = Properties.Resources.foxy_running_19;
        public static Bitmap cam2A15 = Properties.Resources.foxy_running_20;
        public static Bitmap cam2A16 = Properties.Resources.foxy_running_21;
        public static Bitmap cam2A17 = Properties.Resources.foxy_running_22;
        public static Bitmap cam2A18 = Properties.Resources.foxy_running_23;
        public static Bitmap cam2A19 = Properties.Resources.foxy_running_24;
        public static Bitmap cam2A20 = Properties.Resources.foxy_running_25;
        public static Bitmap cam2A21 = Properties.Resources.foxy_running_26;
        public static Bitmap cam2A22 = Properties.Resources.foxy_running_27;
        public static Bitmap cam2A23 = Properties.Resources.foxy_running_28;
        public static Bitmap cam2A24 = Properties.Resources.foxy_running_29;
        public static Bitmap cam2A25 = Properties.Resources.foxy_running_30;
        public static Bitmap cam2A26 = Properties.Resources.foxy_running_31;
        public static Bitmap cam2A27 = Properties.Resources.foxy_running_32;
        public static Bitmap cam2A28 = Properties.Resources.foxy_running_33;
        public static Bitmap cam2A29 = Properties.Resources.foxy_running_34;
        public static Bitmap cam2A30 = Properties.Resources.foxy_running_35;

        public static Bitmap cam2Bnone = Properties.Resources._2B_none;
        public static Bitmap cam2BB = Properties.Resources._2B_bonnie;

        public static Bitmap cam3none = Properties.Resources._3_none;
        public static Bitmap cam3B = Properties.Resources._3_bonnie;

        public static Bitmap cam4Anone = Properties.Resources._4Anone;
        public static Bitmap cam4AC = Properties.Resources._4A_chika;
        public static Bitmap cam4AF = Properties.Resources._4A_freddie;

        public static Bitmap cam4Bnone = Properties.Resources._4B_none;
        public static Bitmap cam4BF = Properties.Resources._4B_freddie;
        public static Bitmap cam4BC = Properties.Resources._4B_chika;

        public static Bitmap cam5none = Properties.Resources._5_none;
        public static Bitmap cam5B = Properties.Resources._5_bonnie;

        public static Bitmap cam7none = Properties.Resources._7none;
        public static Bitmap cam7C = Properties.Resources._7_chika;
        public static Bitmap cam7F = Properties.Resources._7_freddie;

        public static Bitmap leftbuttonsoff = Properties.Resources.leftoff;
        public static Bitmap leftbuttondoor = Properties.Resources.leftdoorclosed;
        public static Bitmap leftbuttonson = Properties.Resources.leftlightanddoor;
        public static Bitmap leftbuttonlight = Properties.Resources.leftlighton;

        public static Bitmap rightbuttondoor = Properties.Resources.rightdoorclosed;
        public static Bitmap rightbuttonson = Properties.Resources.rightlightanddoor__2_;
        public static Bitmap rightbuttonlight = Properties.Resources.rightlighton;
        public static Bitmap rightbuttonsoff = Properties.Resources.rightoff;

        public static Bitmap rightdoor1 = Properties.Resources.rightdoor1;
        public static Bitmap rightdoor2 = Properties.Resources.rightdoor2;
        public static Bitmap rightdoor3 = Properties.Resources.rightdoor3;
        public static Bitmap rightdoor4 = Properties.Resources.rightdoor4;
        public static Bitmap rightdoor5 = Properties.Resources.rightdoor5;
        public static Bitmap rightdoor6 = Properties.Resources.rightdoor6;
        public static Bitmap rightdoor7 = Properties.Resources.rightdoor7;
        public static Bitmap rightdoor8 = Properties.Resources.rightdoor8;
        public static Bitmap rightdoor9 = Properties.Resources.rightdoor9;
        public static Bitmap rightdoor10 = Properties.Resources.rightdoor10;
        public static Bitmap rightdoor11 = Properties.Resources.rightdoor11;
        public static Bitmap rightdoor12 = Properties.Resources.rightdoor12;
        public static Bitmap rightdoor13 = Properties.Resources.rightdoor13;
        public static Bitmap rightdoor14 = Properties.Resources.rightdoor14;


        public static Bitmap leftdoor1 = Properties.Resources.leftdoor1;
        public static Bitmap leftdoor2 = Properties.Resources.leftdoor2;
        public static Bitmap leftdoor3 = Properties.Resources.leftdoor3;
        public static Bitmap leftdoor4 = Properties.Resources.leftdoor4;
        public static Bitmap leftdoor5 = Properties.Resources.leftdoor5;
        public static Bitmap leftdoor6 = Properties.Resources.leftdoor6;
        public static Bitmap leftdoor7 = Properties.Resources.leftdoor7;
        public static Bitmap leftdoor8 = Properties.Resources.leftdoor8;
        public static Bitmap leftdoor9 = Properties.Resources.leftdoor9;
        public static Bitmap leftdoor10 = Properties.Resources.leftdoor10;
        public static Bitmap leftdoor11 = Properties.Resources.leftdoor11;
        public static Bitmap leftdoor12 = Properties.Resources.leftdoor12;
        public static Bitmap leftdoor13 = Properties.Resources.leftdoor13;
        public static Bitmap leftdoor14 = Properties.Resources.leftdoor14;

        public static Bitmap bonnyscare1 = Properties.Resources.bonnie_jumpscare_1;
        public static Bitmap bonnyscare2 = Properties.Resources.bonnie_jumpscare_2;
        public static Bitmap bonnyscare3 = Properties.Resources.bonnie_jumpscare_3;
        public static Bitmap bonnyscare4 = Properties.Resources.bonnie_jumpscare_4;
        public static Bitmap bonnyscare5 = Properties.Resources.bonnie_jumpscare_5;
        public static Bitmap bonnyscare6 = Properties.Resources.bonnie_jumpscare_6;
        public static Bitmap bonnyscare7 = Properties.Resources.bonnie_jumpscare_7;
        public static Bitmap bonnyscare8 = Properties.Resources.bonnie_jumpscare_8;
        public static Bitmap bonnyscare9 = Properties.Resources.bonnie_jumpscare_9;

        public static Bitmap chikascare1 = Properties.Resources.chika_animation_1;
        public static Bitmap chikascare2 = Properties.Resources.chika_animation_2;
        public static Bitmap chikascare3 = Properties.Resources.chika_animation_3;
        public static Bitmap chikascare4 = Properties.Resources.chika_animation_4;
        public static Bitmap chikascare5 = Properties.Resources.chika_animation_5;
        public static Bitmap chikascare6 = Properties.Resources.chika_animation_6;
        public static Bitmap chikascare7 = Properties.Resources.chika_animation_7;
        public static Bitmap chikascare8 = Properties.Resources.chika_animation_8;
        public static Bitmap chikascare9 = Properties.Resources.chika_animation_9;
        public static Bitmap chikascare10 = Properties.Resources.chika_animation_10;
        public static Bitmap chikascare11 = Properties.Resources.chika_animation_11;
        public static Bitmap chikascare12 = Properties.Resources.chika_animation_12;
        public static Bitmap chikascare13 = Properties.Resources.chika_animation_13;
        public static Bitmap chikascare14 = Properties.Resources.chika_animation_14;
        public static Bitmap chikascare15 = Properties.Resources.chika_animation_15;
        public static Bitmap chikascare16 = Properties.Resources.chika_animation_16;

        #endregion
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

