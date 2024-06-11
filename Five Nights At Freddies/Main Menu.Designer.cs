namespace Five_Nights_At_Freddies
{
    partial class Main_Menu
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
            this.Newgamebutton = new System.Windows.Forms.Button();
            this.Continuebutton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Newgamebutton
            // 
            this.Newgamebutton.AutoSize = true;
            this.Newgamebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Newgamebutton.BackColor = System.Drawing.Color.Transparent;
            this.Newgamebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Newgamebutton.FlatAppearance.BorderSize = 0;
            this.Newgamebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Newgamebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Newgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newgamebutton.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newgamebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Newgamebutton.Location = new System.Drawing.Point(156, 80);
            this.Newgamebutton.Name = "Newgamebutton";
            this.Newgamebutton.Size = new System.Drawing.Size(277, 83);
            this.Newgamebutton.TabIndex = 0;
            this.Newgamebutton.Text = "button1";
            this.Newgamebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newgamebutton.UseVisualStyleBackColor = false;
            this.Newgamebutton.Click += new System.EventHandler(this.Newgamebutton_Click);
            this.Newgamebutton.MouseEnter += new System.EventHandler(this.Newgamebutton_MouseEnter);
            this.Newgamebutton.MouseLeave += new System.EventHandler(this.Newgamebutton_MouseLeave);
            // 
            // Continuebutton
            // 
            this.Continuebutton.AutoSize = true;
            this.Continuebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Continuebutton.BackColor = System.Drawing.Color.Transparent;
            this.Continuebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Continuebutton.FlatAppearance.BorderSize = 0;
            this.Continuebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Continuebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Continuebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continuebutton.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Continuebutton.Location = new System.Drawing.Point(32, 224);
            this.Continuebutton.Name = "Continuebutton";
            this.Continuebutton.Size = new System.Drawing.Size(277, 83);
            this.Continuebutton.TabIndex = 1;
            this.Continuebutton.Text = "button2";
            this.Continuebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Continuebutton.UseVisualStyleBackColor = false;
            this.Continuebutton.Click += new System.EventHandler(this.Continuebutton_Click);
            this.Continuebutton.MouseEnter += new System.EventHandler(this.Continuebutton_MouseEnter);
            this.Continuebutton.MouseLeave += new System.EventHandler(this.Continuebutton_MouseLeave);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(623, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 292);
            this.label1.TabIndex = 2;
            this.label1.Text = "Five\r\nNights\r\nAt \r\nFreddies\r\n";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continuebutton);
            this.Controls.Add(this.Newgamebutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Main_Menu";
            this.Size = new System.Drawing.Size(1043, 593);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Menu_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Newgamebutton;
        private System.Windows.Forms.Button Continuebutton;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
    }
}
