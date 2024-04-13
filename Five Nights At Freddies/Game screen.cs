using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class Game_screen : UserControl
    {
        public Game_screen()
        {
            InitializeComponent();
            gameTimer.Start();
            this.BackColor = Color.Black;
            cameraButton.Size = new System.Drawing.Size(782, 56);
            cameraButton.Location = new System.Drawing.Point(this.Width + 250, (this.Height - 15) * 6);
            cameraButton.Enabled = true;
        }
        private void cameraButton_MouseLeave(object sender, EventArgs e)
        {
            cameraButton.Enabled = true;
        }
        private void cameraButton_MouseHover(object sender, EventArgs e)
        {
            cameraButton.Enabled = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            cameraButton.Enabled = true;
        }

        
    }
}
