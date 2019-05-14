namespace ImportingApplyingModel
{
    partial class IMPORTINGDATA
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
            this.label2 = new System.Windows.Forms.Label();
            this.TEXTFILEPATH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ROWDELIMITER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.COLUMNDELIMITER = new System.Windows.Forms.TextBox();
            this.GOTOSECONDFORM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EXCELFILEPATH = new System.Windows.Forms.TextBox();
            this.BROWSETEXTFILE = new System.Windows.Forms.Button();
            this.BROWSEEXCELFILE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Importing Data and Apply Constraints Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the path of the file ";
            // 
            // TEXTFILEPATH
            // 
            this.TEXTFILEPATH.Location = new System.Drawing.Point(342, 112);
            this.TEXTFILEPATH.Margin = new System.Windows.Forms.Padding(2);
            this.TEXTFILEPATH.Name = "TEXTFILEPATH";
            this.TEXTFILEPATH.Size = new System.Drawing.Size(131, 20);
            this.TEXTFILEPATH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter row delimiter";
            // 
            // ROWDELIMITER
            // 
            this.ROWDELIMITER.Location = new System.Drawing.Point(239, 263);
            this.ROWDELIMITER.Margin = new System.Windows.Forms.Padding(2);
            this.ROWDELIMITER.Name = "ROWDELIMITER";
            this.ROWDELIMITER.Size = new System.Drawing.Size(103, 20);
            this.ROWDELIMITER.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter column delimiter";
            // 
            // COLUMNDELIMITER
            // 
            this.COLUMNDELIMITER.Location = new System.Drawing.Point(655, 262);
            this.COLUMNDELIMITER.Margin = new System.Windows.Forms.Padding(2);
            this.COLUMNDELIMITER.Name = "COLUMNDELIMITER";
            this.COLUMNDELIMITER.Size = new System.Drawing.Size(103, 20);
            this.COLUMNDELIMITER.TabIndex = 8;
            // 
            // GOTOSECONDFORM
            // 
            this.GOTOSECONDFORM.Location = new System.Drawing.Point(380, 377);
            this.GOTOSECONDFORM.Margin = new System.Windows.Forms.Padding(2);
            this.GOTOSECONDFORM.Name = "GOTOSECONDFORM";
            this.GOTOSECONDFORM.Size = new System.Drawing.Size(185, 24);
            this.GOTOSECONDFORM.TabIndex = 9;
            this.GOTOSECONDFORM.Text = "Next ";
            this.GOTOSECONDFORM.UseVisualStyleBackColor = true;
            this.GOTOSECONDFORM.Click += new System.EventHandler(this.GOTOSECONDFORM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Excel file ";
            // 
            // EXCELFILEPATH
            // 
            this.EXCELFILEPATH.Location = new System.Drawing.Point(342, 181);
            this.EXCELFILEPATH.Margin = new System.Windows.Forms.Padding(2);
            this.EXCELFILEPATH.Name = "EXCELFILEPATH";
            this.EXCELFILEPATH.Size = new System.Drawing.Size(131, 20);
            this.EXCELFILEPATH.TabIndex = 11;
            // 
            // BROWSETEXTFILE
            // 
            this.BROWSETEXTFILE.Location = new System.Drawing.Point(239, 113);
            this.BROWSETEXTFILE.Margin = new System.Windows.Forms.Padding(2);
            this.BROWSETEXTFILE.Name = "BROWSETEXTFILE";
            this.BROWSETEXTFILE.Size = new System.Drawing.Size(86, 19);
            this.BROWSETEXTFILE.TabIndex = 12;
            this.BROWSETEXTFILE.Text = "Choose file";
            this.BROWSETEXTFILE.UseVisualStyleBackColor = true;
            this.BROWSETEXTFILE.Click += new System.EventHandler(this.BROWSETEXTFILE_Click);
            // 
            // BROWSEEXCELFILE
            // 
            this.BROWSEEXCELFILE.Location = new System.Drawing.Point(239, 181);
            this.BROWSEEXCELFILE.Margin = new System.Windows.Forms.Padding(2);
            this.BROWSEEXCELFILE.Name = "BROWSEEXCELFILE";
            this.BROWSEEXCELFILE.Size = new System.Drawing.Size(86, 19);
            this.BROWSEEXCELFILE.TabIndex = 13;
            this.BROWSEEXCELFILE.Text = "Choose file";
            this.BROWSEEXCELFILE.UseVisualStyleBackColor = true;
            this.BROWSEEXCELFILE.Click += new System.EventHandler(this.BROWSEEXCELFILE_Click);
            // 
            // IMPORTINGDATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 427);
            this.Controls.Add(this.BROWSEEXCELFILE);
            this.Controls.Add(this.BROWSETEXTFILE);
            this.Controls.Add(this.EXCELFILEPATH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GOTOSECONDFORM);
            this.Controls.Add(this.COLUMNDELIMITER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ROWDELIMITER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TEXTFILEPATH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IMPORTINGDATA";
            this.Text = "Importing Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TEXTFILEPATH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox ROWDELIMITER;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox COLUMNDELIMITER;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox EXCELFILEPATH;
        public System.Windows.Forms.Button GOTOSECONDFORM;
        public System.Windows.Forms.Button BROWSETEXTFILE;
        private System.Windows.Forms.Button BROWSEEXCELFILE;
    }
}

