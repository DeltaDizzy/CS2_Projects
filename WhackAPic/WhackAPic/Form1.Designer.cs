namespace WhackAPic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrStarter = new System.Windows.Forms.Timer(this.components);
            this.lblStarter = new System.Windows.Forms.Label();
            this.tmrMover = new System.Windows.Forms.Timer(this.components);
            this.pbMyth = new System.Windows.Forms.PictureBox();
            this.pbMole = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHighScore);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblCountdown);
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 98);
            this.panel1.TabIndex = 3;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(3, 39);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(132, 39);
            this.lblHighScore.TabIndex = 2;
            this.lblHighScore.Text = "High Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(389, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(212, 39);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(137, 39);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "Countdown:";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // tmrStarter
            // 
            this.tmrStarter.Interval = 1000;
            this.tmrStarter.Tick += new System.EventHandler(this.tmrStarter_Tick);
            // 
            // lblStarter
            // 
            this.lblStarter.AutoSize = true;
            this.lblStarter.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarter.Location = new System.Drawing.Point(258, 167);
            this.lblStarter.Name = "lblStarter";
            this.lblStarter.Size = new System.Drawing.Size(32, 39);
            this.lblStarter.TabIndex = 2;
            this.lblStarter.Text = "3";
            // 
            // tmrMover
            // 
            this.tmrMover.Tick += new System.EventHandler(this.tmrMover_Tick);
            // 
            // pbMyth
            // 
            this.pbMyth.Image = global::WhackAPic.Properties.Resources.wow;
            this.pbMyth.Location = new System.Drawing.Point(396, 62);
            this.pbMyth.Name = "pbMyth";
            this.pbMyth.Size = new System.Drawing.Size(117, 113);
            this.pbMyth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMyth.TabIndex = 4;
            this.pbMyth.TabStop = false;
            this.pbMyth.Click += new System.EventHandler(this.pbMyth_Click);
            // 
            // pbMole
            // 
            this.pbMole.Location = new System.Drawing.Point(0, 0);
            this.pbMole.Name = "pbMole";
            this.pbMole.Size = new System.Drawing.Size(117, 113);
            this.pbMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMole.TabIndex = 0;
            this.pbMole.TabStop = false;
            this.pbMole.Click += new System.EventHandler(this.pbMole_Click);
            this.pbMole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMole_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.pbMyth);
            this.Controls.Add(this.lblStarter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Timer tmrStarter;
        private System.Windows.Forms.Label lblStarter;
        private System.Windows.Forms.Timer tmrMover;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.PictureBox pbMyth;
    }
}

