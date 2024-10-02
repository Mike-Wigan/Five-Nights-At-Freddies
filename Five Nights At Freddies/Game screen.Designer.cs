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
            this.camflip = new System.Windows.Forms.Timer(this.components);
            this.cam1Abutton = new System.Windows.Forms.Button();
            this.cam1Bbutton = new System.Windows.Forms.Button();
            this.cam1Cbutton = new System.Windows.Forms.Button();
            this.cam2Abutton = new System.Windows.Forms.Button();
            this.cam2Bbutton = new System.Windows.Forms.Button();
            this.cam3button = new System.Windows.Forms.Button();
            this.cam4Abutton = new System.Windows.Forms.Button();
            this.cam4Bbutton = new System.Windows.Forms.Button();
            this.cam5button = new System.Windows.Forms.Button();
            this.cam6button = new System.Windows.Forms.Button();
            this.cam7button = new System.Windows.Forms.Button();
            this.leftlightbutton = new System.Windows.Forms.Button();
            this.rightlightbutton = new System.Windows.Forms.Button();
            this.leftdoorbutton = new System.Windows.Forms.Button();
            this.rightdoorbutton = new System.Windows.Forms.Button();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // cameraButton
            // 
            this.cameraButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cameraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.ForeColor = System.Drawing.Color.Transparent;
            this.cameraButton.Location = new System.Drawing.Point(297, 245);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(159, 24);
            this.cameraButton.TabIndex = 0;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.MouseEnter += new System.EventHandler(this.cameraButton_MouseEnter);
            // 
            // camflip
            // 
            this.camflip.Interval = 1;
            this.camflip.Tick += new System.EventHandler(this.camflip_Tick);
            // 
            // cam1Abutton
            // 
            this.cam1Abutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam1Abutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam1Abutton.FlatAppearance.BorderSize = 3;
            this.cam1Abutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam1Abutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam1Abutton.Location = new System.Drawing.Point(168, 291);
            this.cam1Abutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam1Abutton.Name = "cam1Abutton";
            this.cam1Abutton.Size = new System.Drawing.Size(56, 19);
            this.cam1Abutton.TabIndex = 14;
            this.cam1Abutton.Text = "button1";
            this.cam1Abutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam1Abutton.UseVisualStyleBackColor = false;
            this.cam1Abutton.Click += new System.EventHandler(this.cam1Abutton_Click);
            // 
            // cam1Bbutton
            // 
            this.cam1Bbutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam1Bbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam1Bbutton.FlatAppearance.BorderSize = 3;
            this.cam1Bbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam1Bbutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam1Bbutton.Location = new System.Drawing.Point(168, 354);
            this.cam1Bbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam1Bbutton.Name = "cam1Bbutton";
            this.cam1Bbutton.Size = new System.Drawing.Size(56, 19);
            this.cam1Bbutton.TabIndex = 15;
            this.cam1Bbutton.Text = "button2";
            this.cam1Bbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam1Bbutton.UseVisualStyleBackColor = false;
            this.cam1Bbutton.Click += new System.EventHandler(this.cam1Bbutton_Click);
            // 
            // cam1Cbutton
            // 
            this.cam1Cbutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam1Cbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam1Cbutton.FlatAppearance.BorderSize = 3;
            this.cam1Cbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam1Cbutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam1Cbutton.Location = new System.Drawing.Point(168, 408);
            this.cam1Cbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam1Cbutton.Name = "cam1Cbutton";
            this.cam1Cbutton.Size = new System.Drawing.Size(56, 19);
            this.cam1Cbutton.TabIndex = 16;
            this.cam1Cbutton.Text = "button2";
            this.cam1Cbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam1Cbutton.UseVisualStyleBackColor = false;
            this.cam1Cbutton.Click += new System.EventHandler(this.cam1Cbutton_Click);
            // 
            // cam2Abutton
            // 
            this.cam2Abutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam2Abutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam2Abutton.FlatAppearance.BorderSize = 3;
            this.cam2Abutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam2Abutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam2Abutton.Location = new System.Drawing.Point(287, 291);
            this.cam2Abutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam2Abutton.Name = "cam2Abutton";
            this.cam2Abutton.Size = new System.Drawing.Size(56, 19);
            this.cam2Abutton.TabIndex = 17;
            this.cam2Abutton.Text = "button2";
            this.cam2Abutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam2Abutton.UseVisualStyleBackColor = false;
            this.cam2Abutton.Click += new System.EventHandler(this.cam2Abutton_Click);
            // 
            // cam2Bbutton
            // 
            this.cam2Bbutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam2Bbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam2Bbutton.FlatAppearance.BorderSize = 3;
            this.cam2Bbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam2Bbutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam2Bbutton.Location = new System.Drawing.Point(287, 354);
            this.cam2Bbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam2Bbutton.Name = "cam2Bbutton";
            this.cam2Bbutton.Size = new System.Drawing.Size(56, 19);
            this.cam2Bbutton.TabIndex = 18;
            this.cam2Bbutton.Text = "button2";
            this.cam2Bbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam2Bbutton.UseVisualStyleBackColor = false;
            this.cam2Bbutton.Click += new System.EventHandler(this.cam2Bbutton_Click);
            // 
            // cam3button
            // 
            this.cam3button.BackColor = System.Drawing.Color.DarkGray;
            this.cam3button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam3button.FlatAppearance.BorderSize = 3;
            this.cam3button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam3button.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam3button.Location = new System.Drawing.Point(287, 408);
            this.cam3button.Margin = new System.Windows.Forms.Padding(2);
            this.cam3button.Name = "cam3button";
            this.cam3button.Size = new System.Drawing.Size(56, 19);
            this.cam3button.TabIndex = 19;
            this.cam3button.Text = "button2";
            this.cam3button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam3button.UseVisualStyleBackColor = false;
            this.cam3button.Click += new System.EventHandler(this.cam3button_Click);
            // 
            // cam4Abutton
            // 
            this.cam4Abutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam4Abutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam4Abutton.FlatAppearance.BorderSize = 3;
            this.cam4Abutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam4Abutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam4Abutton.Location = new System.Drawing.Point(400, 291);
            this.cam4Abutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam4Abutton.Name = "cam4Abutton";
            this.cam4Abutton.Size = new System.Drawing.Size(56, 19);
            this.cam4Abutton.TabIndex = 20;
            this.cam4Abutton.Text = "button2";
            this.cam4Abutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam4Abutton.UseVisualStyleBackColor = false;
            this.cam4Abutton.Click += new System.EventHandler(this.cam4Abutton_Click);
            // 
            // cam4Bbutton
            // 
            this.cam4Bbutton.BackColor = System.Drawing.Color.DarkGray;
            this.cam4Bbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam4Bbutton.FlatAppearance.BorderSize = 3;
            this.cam4Bbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam4Bbutton.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam4Bbutton.Location = new System.Drawing.Point(404, 354);
            this.cam4Bbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cam4Bbutton.Name = "cam4Bbutton";
            this.cam4Bbutton.Size = new System.Drawing.Size(56, 19);
            this.cam4Bbutton.TabIndex = 21;
            this.cam4Bbutton.Text = "button2";
            this.cam4Bbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam4Bbutton.UseVisualStyleBackColor = false;
            this.cam4Bbutton.Click += new System.EventHandler(this.cam4Bbutton_Click);
            // 
            // cam5button
            // 
            this.cam5button.BackColor = System.Drawing.Color.DarkGray;
            this.cam5button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam5button.FlatAppearance.BorderSize = 3;
            this.cam5button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam5button.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam5button.Location = new System.Drawing.Point(404, 408);
            this.cam5button.Margin = new System.Windows.Forms.Padding(2);
            this.cam5button.Name = "cam5button";
            this.cam5button.Size = new System.Drawing.Size(56, 19);
            this.cam5button.TabIndex = 22;
            this.cam5button.Text = "button2";
            this.cam5button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam5button.UseVisualStyleBackColor = false;
            this.cam5button.Click += new System.EventHandler(this.cam5button_Click);
            // 
            // cam6button
            // 
            this.cam6button.BackColor = System.Drawing.Color.DarkGray;
            this.cam6button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam6button.FlatAppearance.BorderSize = 3;
            this.cam6button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam6button.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam6button.Location = new System.Drawing.Point(502, 291);
            this.cam6button.Margin = new System.Windows.Forms.Padding(2);
            this.cam6button.Name = "cam6button";
            this.cam6button.Size = new System.Drawing.Size(56, 19);
            this.cam6button.TabIndex = 23;
            this.cam6button.Text = "button2";
            this.cam6button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam6button.UseVisualStyleBackColor = false;
            this.cam6button.Click += new System.EventHandler(this.cam6button_Click);
            // 
            // cam7button
            // 
            this.cam7button.BackColor = System.Drawing.Color.DarkGray;
            this.cam7button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cam7button.FlatAppearance.BorderSize = 3;
            this.cam7button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cam7button.Font = new System.Drawing.Font("Nirmala UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cam7button.Location = new System.Drawing.Point(502, 352);
            this.cam7button.Margin = new System.Windows.Forms.Padding(2);
            this.cam7button.Name = "cam7button";
            this.cam7button.Size = new System.Drawing.Size(56, 19);
            this.cam7button.TabIndex = 24;
            this.cam7button.Text = "button2";
            this.cam7button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cam7button.UseVisualStyleBackColor = false;
            this.cam7button.Click += new System.EventHandler(this.cam7button_Click);
            // 
            // leftlightbutton
            // 
            this.leftlightbutton.BackColor = System.Drawing.Color.White;
            this.leftlightbutton.FlatAppearance.BorderSize = 0;
            this.leftlightbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.leftlightbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftlightbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftlightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftlightbutton.ForeColor = System.Drawing.Color.Transparent;
            this.leftlightbutton.Location = new System.Drawing.Point(297, 145);
            this.leftlightbutton.Margin = new System.Windows.Forms.Padding(2);
            this.leftlightbutton.Name = "leftlightbutton";
            this.leftlightbutton.Size = new System.Drawing.Size(56, 19);
            this.leftlightbutton.TabIndex = 27;
            this.leftlightbutton.UseVisualStyleBackColor = false;
            this.leftlightbutton.Click += new System.EventHandler(this.leftlightbutton_Click);
            // 
            // rightlightbutton
            // 
            this.rightlightbutton.BackColor = System.Drawing.Color.White;
            this.rightlightbutton.FlatAppearance.BorderSize = 0;
            this.rightlightbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rightlightbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightlightbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightlightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightlightbutton.ForeColor = System.Drawing.Color.Transparent;
            this.rightlightbutton.Location = new System.Drawing.Point(404, 145);
            this.rightlightbutton.Margin = new System.Windows.Forms.Padding(2);
            this.rightlightbutton.Name = "rightlightbutton";
            this.rightlightbutton.Size = new System.Drawing.Size(56, 19);
            this.rightlightbutton.TabIndex = 28;
            this.rightlightbutton.UseVisualStyleBackColor = false;
            this.rightlightbutton.Click += new System.EventHandler(this.rightlightbutton_Click);
            // 
            // leftdoorbutton
            // 
            this.leftdoorbutton.BackColor = System.Drawing.Color.White;
            this.leftdoorbutton.FlatAppearance.BorderSize = 0;
            this.leftdoorbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.leftdoorbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftdoorbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftdoorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftdoorbutton.ForeColor = System.Drawing.Color.Transparent;
            this.leftdoorbutton.Location = new System.Drawing.Point(297, 191);
            this.leftdoorbutton.Margin = new System.Windows.Forms.Padding(2);
            this.leftdoorbutton.Name = "leftdoorbutton";
            this.leftdoorbutton.Size = new System.Drawing.Size(56, 19);
            this.leftdoorbutton.TabIndex = 29;
            this.leftdoorbutton.UseVisualStyleBackColor = false;
            this.leftdoorbutton.Click += new System.EventHandler(this.leftdoorbutton_Click);
            // 
            // rightdoorbutton
            // 
            this.rightdoorbutton.BackColor = System.Drawing.Color.White;
            this.rightdoorbutton.FlatAppearance.BorderSize = 0;
            this.rightdoorbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rightdoorbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightdoorbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightdoorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightdoorbutton.ForeColor = System.Drawing.Color.Transparent;
            this.rightdoorbutton.Location = new System.Drawing.Point(404, 199);
            this.rightdoorbutton.Margin = new System.Windows.Forms.Padding(2);
            this.rightdoorbutton.Name = "rightdoorbutton";
            this.rightdoorbutton.Size = new System.Drawing.Size(56, 19);
            this.rightdoorbutton.TabIndex = 30;
            this.rightdoorbutton.UseVisualStyleBackColor = false;
            this.rightdoorbutton.Click += new System.EventHandler(this.rightdoorbutton_Click);
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverlabel.ForeColor = System.Drawing.Color.Red;
            this.gameoverlabel.Location = new System.Drawing.Point(382, 181);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(492, 108);
            this.gameoverlabel.TabIndex = 31;
            this.gameoverlabel.Text = "Gameover";
            // 
            // timerlabel
            // 
            this.timerlabel.BackColor = System.Drawing.Color.Transparent;
            this.timerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.ForeColor = System.Drawing.Color.White;
            this.timerlabel.Location = new System.Drawing.Point(428, 67);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(153, 23);
            this.timerlabel.TabIndex = 32;
            this.timerlabel.Text = "label1";
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Game_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.rightdoorbutton);
            this.Controls.Add(this.leftdoorbutton);
            this.Controls.Add(this.rightlightbutton);
            this.Controls.Add(this.leftlightbutton);
            this.Controls.Add(this.cam7button);
            this.Controls.Add(this.cam6button);
            this.Controls.Add(this.cam5button);
            this.Controls.Add(this.cam4Bbutton);
            this.Controls.Add(this.cam4Abutton);
            this.Controls.Add(this.cam3button);
            this.Controls.Add(this.cam2Bbutton);
            this.Controls.Add(this.cam2Abutton);
            this.Controls.Add(this.cam1Cbutton);
            this.Controls.Add(this.cam1Bbutton);
            this.Controls.Add(this.cam1Abutton);
            this.Controls.Add(this.cameraButton);
            this.DoubleBuffered = true;
            this.Name = "Game_screen";
            this.Size = new System.Drawing.Size(1012, 715);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_screen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer camflip;
        private System.Windows.Forms.Button cam1Abutton;
        private System.Windows.Forms.Button cam1Bbutton;
        private System.Windows.Forms.Button cam1Cbutton;
        private System.Windows.Forms.Button cam2Abutton;
        private System.Windows.Forms.Button cam2Bbutton;
        private System.Windows.Forms.Button cam3button;
        private System.Windows.Forms.Button cam4Abutton;
        private System.Windows.Forms.Button cam4Bbutton;
        private System.Windows.Forms.Button cam5button;
        private System.Windows.Forms.Button cam6button;
        private System.Windows.Forms.Button cam7button;
        private System.Windows.Forms.Button leftlightbutton;
        private System.Windows.Forms.Button rightlightbutton;
        private System.Windows.Forms.Button leftdoorbutton;
        private System.Windows.Forms.Button rightdoorbutton;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
