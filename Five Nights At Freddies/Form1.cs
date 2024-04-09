using System.Drawing;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Main_Menu mm = new Main_Menu();;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            mm.Size = this.Size;

            f.Controls.Add(mm);
            mm.Focus();
            f.Controls.Remove(this);

            WindowState = FormWindowState.Maximized;
        }
    }
}
