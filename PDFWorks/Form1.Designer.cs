namespace PDFWorks
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
            this.btnFirstSelect = new System.Windows.Forms.Button();
            this.btnSecondSelect = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblFirstFile = new System.Windows.Forms.Label();
            this.lblSecondFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnFirstSelect
            // 
            this.btnFirstSelect.Location = new System.Drawing.Point(12, 12);
            this.btnFirstSelect.Name = "btnFirstSelect";
            this.btnFirstSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFirstSelect.TabIndex = 0;
            this.btnFirstSelect.Text = "İlk PDF";
            this.btnFirstSelect.UseVisualStyleBackColor = true;
            this.btnFirstSelect.Click += new System.EventHandler(this.btnFirstSelect_Click);
            // 
            // btnSecondSelect
            // 
            this.btnSecondSelect.Location = new System.Drawing.Point(12, 41);
            this.btnSecondSelect.Name = "btnSecondSelect";
            this.btnSecondSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSecondSelect.TabIndex = 0;
            this.btnSecondSelect.Text = "İkinci PDF";
            this.btnSecondSelect.UseVisualStyleBackColor = true;
            this.btnSecondSelect.Click += new System.EventHandler(this.btnSecondSelect_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(12, 70);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(570, 23);
            this.btnMerge.TabIndex = 0;
            this.btnMerge.Text = "Birleştir";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lblFirstFile
            // 
            this.lblFirstFile.AutoSize = true;
            this.lblFirstFile.Location = new System.Drawing.Point(102, 17);
            this.lblFirstFile.Name = "lblFirstFile";
            this.lblFirstFile.Size = new System.Drawing.Size(0, 13);
            this.lblFirstFile.TabIndex = 1;
            // 
            // lblSecondFile
            // 
            this.lblSecondFile.AutoSize = true;
            this.lblSecondFile.Location = new System.Drawing.Point(102, 46);
            this.lblSecondFile.Name = "lblSecondFile";
            this.lblSecondFile.Size = new System.Drawing.Size(0, 13);
            this.lblSecondFile.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 97);
            this.Controls.Add(this.lblSecondFile);
            this.Controls.Add(this.lblFirstFile);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnSecondSelect);
            this.Controls.Add(this.btnFirstSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFWorks by farukcakal.xyz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstSelect;
        private System.Windows.Forms.Button btnSecondSelect;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblFirstFile;
        private System.Windows.Forms.Label lblSecondFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

