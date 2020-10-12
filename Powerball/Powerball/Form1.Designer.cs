namespace Powerball
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
            this.mnuMenuBar = new System.Windows.Forms.MenuStrip();
            this.btnPlayIt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRedWinner = new System.Windows.Forms.Label();
            this.lblWhiteWinners = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtNumTickets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuBar
            // 
            this.mnuMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuBar.Name = "mnuMenuBar";
            this.mnuMenuBar.Size = new System.Drawing.Size(800, 30);
            this.mnuMenuBar.TabIndex = 0;
            this.mnuMenuBar.Text = "menuStrip1";
            // 
            // btnPlayIt
            // 
            this.btnPlayIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayIt.Location = new System.Drawing.Point(42, 211);
            this.btnPlayIt.Name = "btnPlayIt";
            this.btnPlayIt.Size = new System.Drawing.Size(327, 72);
            this.btnPlayIt.TabIndex = 1;
            this.btnPlayIt.Text = "win";
            this.btnPlayIt.UseVisualStyleBackColor = true;
            this.btnPlayIt.Click += new System.EventHandler(this.btnPlayIt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.lblRedWinner);
            this.panel1.Controls.Add(this.lblWhiteWinners);
            this.panel1.Controls.Add(this.lstResults);
            this.panel1.Location = new System.Drawing.Point(427, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 421);
            this.panel1.TabIndex = 2;
            // 
            // lblRedWinner
            // 
            this.lblRedWinner.BackColor = System.Drawing.Color.Firebrick;
            this.lblRedWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedWinner.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRedWinner.Location = new System.Drawing.Point(286, 12);
            this.lblRedWinner.Name = "lblRedWinner";
            this.lblRedWinner.Size = new System.Drawing.Size(72, 44);
            this.lblRedWinner.TabIndex = 5;
            this.lblRedWinner.Text = "22,22,22,22,22";
            // 
            // lblWhiteWinners
            // 
            this.lblWhiteWinners.BackColor = System.Drawing.SystemColors.Control;
            this.lblWhiteWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteWinners.Location = new System.Drawing.Point(7, 12);
            this.lblWhiteWinners.Name = "lblWhiteWinners";
            this.lblWhiteWinners.Size = new System.Drawing.Size(286, 44);
            this.lblWhiteWinners.TabIndex = 4;
            this.lblWhiteWinners.Text = "22,22,22,22,22";
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 29;
            this.lstResults.Location = new System.Drawing.Point(22, 59);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(323, 352);
            this.lstResults.TabIndex = 4;
            // 
            // txtNumTickets
            // 
            this.txtNumTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTickets.Location = new System.Drawing.Point(42, 165);
            this.txtNumTickets.Name = "txtNumTickets";
            this.txtNumTickets.Size = new System.Drawing.Size(327, 34);
            this.txtNumTickets.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many Tickets?";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(123, 315);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(156, 36);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumTickets);
            this.Controls.Add(this.btnPlayIt);
            this.Controls.Add(this.mnuMenuBar);
            this.MainMenuStrip = this.mnuMenuBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuBar;
        private System.Windows.Forms.Button btnPlayIt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtNumTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWhiteWinners;
        private System.Windows.Forms.Label lblRedWinner;
        private System.Windows.Forms.Label lblBalance;
    }
}

