namespace MagneticFieldsProg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrIntegrator = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRory = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRory)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrIntegrator
            // 
            this.tmrIntegrator.Enabled = true;
            this.tmrIntegrator.Tick += new System.EventHandler(this.tmrIntegrator_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 926);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 24);
            this.panel1.TabIndex = 0;
            // 
            // pbRory
            // 
            this.pbRory.Image = ((System.Drawing.Image)(resources.GetObject("pbRory.Image")));
            this.pbRory.Location = new System.Drawing.Point(179, 132);
            this.pbRory.Name = "pbRory";
            this.pbRory.Size = new System.Drawing.Size(609, 328);
            this.pbRory.TabIndex = 0;
            this.pbRory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRory);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pbRory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrIntegrator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRory;
        private System.Windows.Forms.Label label1;
    }
}

