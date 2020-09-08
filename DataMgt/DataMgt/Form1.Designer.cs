namespace DataMgt
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverseSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Country:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(226, 44);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(28, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = ">";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 16;
            this.lstList.Location = new System.Drawing.Point(260, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(177, 212);
            this.lstList.TabIndex = 2;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(18, 44);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(202, 40);
            this.txtContent.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(226, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(18, 90);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(202, 40);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Selected";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(18, 136);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 40);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverseSort
            // 
            this.btnReverseSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseSort.Location = new System.Drawing.Point(91, 136);
            this.btnReverseSort.Name = "btnReverseSort";
            this.btnReverseSort.Size = new System.Drawing.Size(163, 40);
            this.btnReverseSort.TabIndex = 7;
            this.btnReverseSort.Text = "Reverse Sort";
            this.btnReverseSort.UseVisualStyleBackColor = true;
            this.btnReverseSort.Click += new System.EventHandler(this.btnReverseSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(18, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(236, 42);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 239);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReverseSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "List Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverseSort;
        private System.Windows.Forms.Button btnClear;
    }
}

