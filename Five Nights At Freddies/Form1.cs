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
        public Form1()
        {
            //InitializeComponent();

            //// Create an instance of the MainScreen
            //Main_Menu mm = new Main_Menu();

            //Form f = this.FindForm();
            //f.Controls.Remove(this);

            //// Add UC to form and give focus
            //this.Controls.Add(mm);
            //mm.Focus();



            //WindowState = FormWindowState.Maximized;


            InitializeComponent();


            this.KeyPreview = true;
            //Form f = this.FindForm();
            //WindowState = FormWindowState.Maximized;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Main_Menu mm = new Main_Menu(); ;
            //mm.Size = this.Size;
            //f.Controls.Add(mm);
            //mm.Focus();
            //f.Controls.Remove(this);
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
            next.Size = Screen.PrimaryScreen.WorkingArea.Size;
            next.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Main_Menu());
            this.KeyPreview = true;
            WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
