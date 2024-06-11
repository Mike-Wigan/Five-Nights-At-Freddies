namespace Five_Nights_At_Freddies
{
    partial class Game_screen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.cameraButton = new System.Windows.Forms.Button();
            this.leftsidelabel = new System.Windows.Forms.Label();
            this.rightsidelabel = new System.Windows.Forms.Label();
            this.camflip = new System.Windows.Forms.Timer(this.components);
            this.cam1Abutton = new System.Windows.Forms.Label();
            this.cam1Bbutton = new System.Windows.Forms.Label();
            this.cam7button = new System.Windows.Forms.Label();
            this.cam6button = new System.Windows.Forms.Label();
            this.cam3button = new System.Windows.Forms.Label();
            this.cam4Abutton = new System.Windows.Forms.Label();
            this.cam4Bbutton = new System.Windows.Forms.Label();
            this.cam1Cbutton = new System.Windows.Forms.Label();
            this.cam2Abutton = new System.Windows.Forms.Label();
            this.cam2Bbutton = new System.Windows.Forms.Label();
            this.cam5button = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // cameraButton
            // 
            this.cameraButton.BackColor = System.Drawing.Color.White;
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.ForeColor = System.Drawing.Color.Transparent;
            this.cameraButton.Location = new System.Drawing.Point(396, 302);
            this.cameraButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(212, 30);
            this.cameraButton.TabIndex = 0;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.MouseEnter += new System.EventHandler(this.cameraButton_MouseEnter);
            this.cameraButton.MouseLeave += new System.EventHandler(this.cameraButton_MouseLeave);
            // 
            // leftsidelabel
            // 
            this.leftsidelabel.BackColor = System.Drawing.Color.White;
            this.leftsidelabel.ForeColor = System.Drawing.Color.Transparent;
            this.leftsidelabel.Location = new System.Drawing.Point(184, 284);
            this.leftsidelabel.Name = "leftsidelabel";
            this.leftsidelabel.Size = new System.Drawing.Size(100, 23);
            this.leftsidelabel.TabIndex = 1;
            this.leftsidelabel.Text = "label1";
            this.leftsidelabel.MouseEnter += new System.EventHandler(this.leftsidelabel_MouseEnter);
            // 
            // rightsidelabel
            // 
            this.rightsidelabel.BackColor = System.Drawing.Color.White;
            this.rightsidelabel.Location = new System.Drawing.Point(748, 203);
            this.rightsidelabel.Name = "rightsidelabel";
            this.rightsidelabel.Size = new System.Drawing.Size(100, 23);
            this.rightsidelabel.TabIndex = 2;
            this.rightsidelabel.Text = "label2";
            this.rightsidelabel.MouseEnter += new System.EventHandler(this.rightsidelabel_MouseEnter);
            // 
            // camflip
            // 
            this.camflip.Interval = 1;
            this.camflip.Tick += new System.EventHandler(this.camflip_Tick);
            // 
            // cam1Abutton
            // 
            this.cam1Abutton.BackColor = System.Drawing.Color.White;
            this.cam1Abutton.Location = new System.Drawing.Point(224, 384);
            this.cam1Abutton.Name = "cam1Abutton";
            this.cam1Abutton.Size = new System.Drawing.Size(100, 23);
            this.cam1Abutton.TabIndex = 3;
            this.cam1Abutton.Text = "label2";
            // 
            // cam1Bbutton
            // 
            this.cam1Bbutton.BackColor = System.Drawing.Color.White;
            this.cam1Bbutton.Location = new System.Drawing.Point(224, 462);
            this.cam1Bbutton.Name = "cam1Bbutton";
            this.cam1Bbutton.Size = new System.Drawing.Size(100, 23);
            this.cam1Bbutton.TabIndex = 4;
            this.cam1Bbutton.Text = "label2";
            // 
            // cam7button
            // 
            this.cam7button.BackColor = System.Drawing.Color.White;
            this.cam7button.Location = new System.Drawing.Point(670, 462);
            this.cam7button.Name = "cam7button";
            this.cam7button.Size = new System.Drawing.Size(100, 23);
            this.cam7button.TabIndex = 5;
            this.cam7button.Text = "label2";
            // 
            // cam6button
            // 
            this.cam6button.BackColor = System.Drawing.Color.White;
            this.cam6button.Location = new System.Drawing.Point(670, 407);
            this.cam6button.Name = "cam6button";
            this.cam6button.Size = new System.Drawing.Size(100, 23);
            this.cam6button.TabIndex = 6;
            this.cam6button.Text = "label2";
            // 
            // cam3button
            // 
            this.cam3button.BackColor = System.Drawing.Color.White;
            this.cam3button.Location = new System.Drawing.Point(383, 528);
            this.cam3button.Name = "cam3button";
            this.cam3button.Size = new System.Drawing.Size(100, 23);
            this.cam3button.TabIndex = 7;
            this.cam3button.Text = "label2";
            // 
            // cam4Abutton
            // 
            this.cam4Abutton.BackColor = System.Drawing.Color.White;
            this.cam4Abutton.Location = new System.Drawing.Point(538, 384);
            this.cam4Abutton.Name = "cam4Abutton";
            this.cam4Abutton.Size = new System.Drawing.Size(100, 23);
            this.cam4Abutton.TabIndex = 8;
            this.cam4Abutton.Text = "label2";
            // 
            // cam4Bbutton
            // 
            this.cam4Bbutton.BackColor = System.Drawing.Color.White;
            this.cam4Bbutton.Location = new System.Drawing.Point(538, 462);
            this.cam4Bbutton.Name = "cam4Bbutton";
            this.cam4Bbutton.Size = new System.Drawing.Size(100, 23);
            this.cam4Bbutton.TabIndex = 9;
            this.cam4Bbutton.Text = "label2";
            // 
            // cam1Cbutton
            // 
            this.cam1Cbutton.BackColor = System.Drawing.Color.White;
            this.cam1Cbutton.Location = new System.Drawing.Point(224, 528);
            this.cam1Cbutton.Name = "cam1Cbutton";
            this.cam1Cbutton.Size = new System.Drawing.Size(100, 23);
            this.cam1Cbutton.TabIndex = 10;
            this.cam1Cbutton.Text = "label2";
            // 
            // cam2Abutton
            // 
            this.cam2Abutton.BackColor = System.Drawing.Color.White;
            this.cam2Abutton.Location = new System.Drawing.Point(383, 384);
            this.cam2Abutton.Name = "cam2Abutton";
            this.cam2Abutton.Size = new System.Drawing.Size(100, 23);
            this.cam2Abutton.TabIndex = 11;
            this.cam2Abutton.Text = "label2";
            // 
            // cam2Bbutton
            // 
            this.cam2Bbutton.BackColor = System.Drawing.Color.White;
            this.cam2Bbutton.Location = new System.Drawing.Point(383, 462);
            this.cam2Bbutton.Name = "cam2Bbutton";
            this.cam2Bbutton.Size = new System.Drawing.Size(100, 23);
            this.cam2Bbutton.TabIndex = 12;
            this.cam2Bbutton.Text = "label2";
            // 
            // cam5button
            // 
            this.cam5button.BackColor = System.Drawing.Color.White;
            this.cam5button.Location = new System.Drawing.Point(538, 528);
            this.cam5button.Name = "cam5button";
            this.cam5button.Size = new System.Drawing.Size(100, 23);
            this.cam5button.TabIndex = 13;
            this.cam5button.Text = "label2";
            // 
            // Game_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cam5button);
            this.Controls.Add(this.cam2Bbutton);
            this.Controls.Add(this.cam2Abutton);
            this.Controls.Add(this.cam1Cbutton);
            this.Controls.Add(this.cam4Bbutton);
            this.Controls.Add(this.cam4Abutton);
            this.Controls.Add(this.cam3button);
            this.Controls.Add(this.cam6button);
            this.Controls.Add(this.cam7button);
            this.Controls.Add(this.cam1Bbutton);
            this.Controls.Add(this.cam1Abutton);
            this.Controls.Add(this.rightsidelabel);
            this.Controls.Add(this.leftsidelabel);
            this.Controls.Add(this.cameraButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game_screen";
            this.Size = new System.Drawing.Size(1034, 663);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_screen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label leftsidelabel;
        private System.Windows.Forms.Label rightsidelabel;
        private System.Windows.Forms.Timer camflip;
        private System.Windows.Forms.Label cam1Abutton;
        private System.Windows.Forms.Label cam1Bbutton;
        private System.Windows.Forms.Label cam7button;
        private System.Windows.Forms.Label cam6button;
        private System.Windows.Forms.Label cam3button;
        private System.Windows.Forms.Label cam4Abutton;
        private System.Windows.Forms.Label cam4Bbutton;
        private System.Windows.Forms.Label cam1Cbutton;
        private System.Windows.Forms.Label cam2Abutton;
        private System.Windows.Forms.Label cam2Bbutton;
        private System.Windows.Forms.Label cam5button;
    }
}
