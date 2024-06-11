namespace Five_Nights_At_Freddies
{
    partial class camscreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameratimer = new System.Windows.Forms.Timer(this.components);
            this.cammap = new System.Windows.Forms.Label();
            this.camerabutton = new System.Windows.Forms.Label();
            this.camfliplabel = new System.Windows.Forms.Label();
            this.camscreengametimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cameratimer
            // 
            this.cameratimer.Enabled = true;
            this.cameratimer.Interval = 20;
            this.cameratimer.Tick += new System.EventHandler(this.camtimer_Tick);
            // 
            // cammap
            // 
            this.cammap.AutoSize = true;
            this.cammap.ForeColor = System.Drawing.Color.White;
            this.cammap.Location = new System.Drawing.Point(376, 102);
            this.cammap.Name = "cammap";
            this.cammap.Size = new System.Drawing.Size(44, 16);
            this.cammap.TabIndex = 0;
            this.cammap.Text = "label1";
            // 
            // camerabutton
            // 
            this.camerabutton.Location = new System.Drawing.Point(368, 158);
            this.camerabutton.Name = "camerabutton";
            this.camerabutton.Size = new System.Drawing.Size(44, 16);
            this.camerabutton.TabIndex = 0;
            this.camerabutton.Text = "label2";
            this.camerabutton.MouseEnter += new System.EventHandler(this.camerabutton_MouseEnter);
            // 
            // camfliplabel
            // 
            this.camfliplabel.BackColor = System.Drawing.Color.Transparent;
            this.camfliplabel.Location = new System.Drawing.Point(597, 132);
            this.camfliplabel.Name = "camfliplabel";
            this.camfliplabel.Size = new System.Drawing.Size(8, 8);
            this.camfliplabel.TabIndex = 1;
            this.camfliplabel.Text = "label1";
            // 
            // camscreengametimer
            // 
            this.camscreengametimer.Enabled = true;
            this.camscreengametimer.Interval = 20;
            this.camscreengametimer.Tick += new System.EventHandler(this.camscreengametimer_Tick);
            // 
            // camscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.camfliplabel);
            this.Controls.Add(this.camerabutton);
            this.Controls.Add(this.cammap);
            this.DoubleBuffered = true;
            this.Name = "camscreen";
            this.Size = new System.Drawing.Size(845, 571);
            this.MouseEnter += new System.EventHandler(this.camscreen_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.camscreen_MouseLeave);
            this.MouseHover += new System.EventHandler(this.camscreen_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer cameratimer;
        private System.Windows.Forms.Label cammap;
        private System.Windows.Forms.Label camerabutton;
        private System.Windows.Forms.Label camfliplabel;
        private System.Windows.Forms.Timer camscreengametimer;
    }
}
