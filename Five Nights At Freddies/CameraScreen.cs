using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Five_Nights_At_Freddies
{
    public partial class CameraScreen : UserControl
    {
        public CameraScreen()
        {
            InitializeComponent();
            cameraTimer.Enabled = true;
            cameraButton.Size = new System.Drawing.Size(782, 56);
            cameraButton.Location = new System.Drawing.Point(this.Width + 250, (this.Height - 15) * 6);
            camMap.Size = new System.Drawing.Size(399, 342);
            camMap.Location = new System.Drawing.Point(this.Width + 1000, (this.Height - 65) * 6);
            
        }

        private void cameraButton_MouseHover(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Game_screen());
            cameraButton.Enabled = false;
        }

        private void cameraButton_MouseLeave(object sender, EventArgs e)
        {
            cameraButton.Enabled = true;
        }

        private void cameraTimer_Tick(object sender, EventArgs e)
        {
            cameraButton.Enabled = true;
            cameraButton.Enabled = true;
        }
    }
}
