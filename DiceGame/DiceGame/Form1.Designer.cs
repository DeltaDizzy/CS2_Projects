namespace DiceGame
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
            this.pbDice0 = new System.Windows.Forms.PictureBox();
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.pbDice3 = new System.Windows.Forms.PictureBox();
            this.pbDice4 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice0
            // 
            this.pbDice0.Location = new System.Drawing.Point(12, 12);
            this.pbDice0.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbDice0.Name = "pbDice0";
            this.pbDice0.Size = new System.Drawing.Size(100, 100);
            this.pbDice0.TabIndex = 0;
            this.pbDice0.TabStop = false;
            // 
            // pbDice1
            // 
            this.pbDice1.Location = new System.Drawing.Point(118, 12);
            this.pbDice1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(100, 100);
            this.pbDice1.TabIndex = 1;
            this.pbDice1.TabStop = false;
            // 
            // pbDice2
            // 
            this.pbDice2.Location = new System.Drawing.Point(224, 12);
            this.pbDice2.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(100, 100);
            this.pbDice2.TabIndex = 2;
            this.pbDice2.TabStop = false;
            // 
            // pbDice3
            // 
            this.pbDice3.Location = new System.Drawing.Point(330, 12);
            this.pbDice3.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbDice3.Name = "pbDice3";
            this.pbDice3.Size = new System.Drawing.Size(100, 100);
            this.pbDice3.TabIndex = 3;
            this.pbDice3.TabStop = false;
            // 
            // pbDice4
            // 
            this.pbDice4.Location = new System.Drawing.Point(436, 12);
            this.pbDice4.MinimumSize = new System.Drawing.Size(100, 100);
            this.pbDice4.Name = "pbDice4";
            this.pbDice4.Size = new System.Drawing.Size(100, 100);
            this.pbDice4.TabIndex = 4;
            this.pbDice4.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(599, 12);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(100, 100);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "button1";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Rough Draft", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(27, 211);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(109, 35);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Rough Draft", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(241, 211);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 30);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "You rolled a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bank:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pbDice4);
            this.Controls.Add(this.pbDice3);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.pbDice1);
            this.Controls.Add(this.pbDice0);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDice0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDice0;
        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.PictureBox pbDice3;
        private System.Windows.Forms.PictureBox pbDice4;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

