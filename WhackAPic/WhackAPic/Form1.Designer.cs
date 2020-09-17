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
            this.pbMole = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrStarter = new System.Windows.Forms.Timer(this.components);
            this.lblStarter = new System.Windows.Forms.Label();
            this.tmrMover = new System.Windows.Forms.Timer(this.components);
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMole
            // 
            this.pbMole.Image = global::WhackAPic.Properties.Resources.gopher;
            this.pbMole.Location = new System.Drawing.Point(0, 0);
            this.pbMole.Name = "pbMole";
            this.pbMole.Size = new System.Drawing.Size(117, 113);
            this.pbMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMole.TabIndex = 0;
            this.pbMole.TabStop = false;
            this.pbMole.Click += new System.EventHandler(this.pbMole_Click);
            this.pbMole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMole_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblCountdown);
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 98);
            this.panel1.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(352, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Poplar Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(12, 39);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.lblStarter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Timer tmr;
    }
}

