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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Newgamebutton
            // 
            this.Newgamebutton.BackColor = System.Drawing.Color.Transparent;
            this.Newgamebutton.FlatAppearance.BorderSize = 0;
            this.Newgamebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Newgamebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Newgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newgamebutton.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newgamebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Newgamebutton.Location = new System.Drawing.Point(214, 123);
            this.Newgamebutton.Name = "Newgamebutton";
            this.Newgamebutton.Size = new System.Drawing.Size(153, 109);
            this.Newgamebutton.TabIndex = 0;
            this.Newgamebutton.Text = "button1";
            this.Newgamebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newgamebutton.UseVisualStyleBackColor = false;
            this.Newgamebutton.Click += new System.EventHandler(this.Newgamebutton_Click);
            // 
            // Continuebutton
            // 
            this.Continuebutton.BackColor = System.Drawing.Color.Transparent;
            this.Continuebutton.FlatAppearance.BorderSize = 0;
            this.Continuebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Continuebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Continuebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continuebutton.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuebutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Continuebutton.Location = new System.Drawing.Point(591, 243);
            this.Continuebutton.Name = "Continuebutton";
            this.Continuebutton.Size = new System.Drawing.Size(75, 50);
            this.Continuebutton.TabIndex = 1;
            this.Continuebutton.Text = "button2";
            this.Continuebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Continuebutton.UseVisualStyleBackColor = false;
            this.Continuebutton.Click += new System.EventHandler(this.Continuebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(55, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = ">>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(376, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.Red;
            this.Exitbutton.Location = new System.Drawing.Point(13, 13);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(101, 38);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continuebutton);
            this.Controls.Add(this.Newgamebutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Main_Menu";
            this.Size = new System.Drawing.Size(948, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Newgamebutton;
        private System.Windows.Forms.Button Continuebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Timer GameTimer;
    }
}
