namespace HardestGame
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.blue1 = new System.Windows.Forms.Label();
            this.blue2 = new System.Windows.Forms.Label();
            this.blue4 = new System.Windows.Forms.Label();
            this.blue3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrBlue = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Red;
            this.lblPlayer.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer.Location = new System.Drawing.Point(63, 30);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(46, 17);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "label1";
            // 
            // blue1
            // 
            this.blue1.AutoSize = true;
            this.blue1.BackColor = System.Drawing.Color.Blue;
            this.blue1.ForeColor = System.Drawing.Color.Blue;
            this.blue1.Location = new System.Drawing.Point(271, 77);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(46, 17);
            this.blue1.TabIndex = 2;
            this.blue1.Text = "label1";
            // 
            // blue2
            // 
            this.blue2.AutoSize = true;
            this.blue2.BackColor = System.Drawing.Color.Blue;
            this.blue2.ForeColor = System.Drawing.Color.Blue;
            this.blue2.Location = new System.Drawing.Point(271, 197);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(46, 17);
            this.blue2.TabIndex = 3;
            this.blue2.Text = "label1";
            // 
            // blue4
            // 
            this.blue4.AutoSize = true;
            this.blue4.BackColor = System.Drawing.Color.Blue;
            this.blue4.ForeColor = System.Drawing.Color.Blue;
            this.blue4.Location = new System.Drawing.Point(733, 258);
            this.blue4.Name = "blue4";
            this.blue4.Size = new System.Drawing.Size(46, 17);
            this.blue4.TabIndex = 4;
            this.blue4.Text = "label1";
            // 
            // blue3
            // 
            this.blue3.AutoSize = true;
            this.blue3.BackColor = System.Drawing.Color.Blue;
            this.blue3.ForeColor = System.Drawing.Color.Blue;
            this.blue3.Location = new System.Drawing.Point(733, 139);
            this.blue3.Name = "blue3";
            this.blue3.Size = new System.Drawing.Size(46, 17);
            this.blue3.TabIndex = 5;
            this.blue3.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(234, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 76);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(288, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 73);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(808, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 304);
            this.panel4.TabIndex = 8;
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 10;
            this.tmrMovement.Tick += new System.EventHandler(this.tmrMovement_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(174, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 300);
            this.panel1.TabIndex = 8;
            // 
            // tmrBlue
            // 
            this.tmrBlue.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HardestGame.Properties.Resources.level1board;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1048, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.blue3);
            this.Controls.Add(this.blue4);
            this.Controls.Add(this.blue2);
            this.Controls.Add(this.blue1);
            this.Controls.Add(this.lblPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label blue1;
        private System.Windows.Forms.Label blue2;
        private System.Windows.Forms.Label blue4;
        private System.Windows.Forms.Label blue3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer tmrMovement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrBlue;
    }
}

