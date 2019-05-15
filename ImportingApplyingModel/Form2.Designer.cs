namespace ImportingApplyingModel
{
    partial class THEORDEROFTHECOLUMN
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
            this.CHOOSECOLUMN = new System.Windows.Forms.ComboBox();
            this.CONFIRMTOGOTOEDITFORM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RETURNTOFIRSTPAGE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHOOSECOLUMN
            // 
            this.CHOOSECOLUMN.FormattingEnabled = true;
            this.CHOOSECOLUMN.Location = new System.Drawing.Point(225, 163);
            this.CHOOSECOLUMN.Margin = new System.Windows.Forms.Padding(2);
            this.CHOOSECOLUMN.Name = "CHOOSECOLUMN";
            this.CHOOSECOLUMN.Size = new System.Drawing.Size(288, 21);
            this.CHOOSECOLUMN.TabIndex = 27;
            this.CHOOSECOLUMN.Text = "Select a column";
            // 
            // CONFIRMTOGOTOEDITFORM
            // 
            this.CONFIRMTOGOTOEDITFORM.Location = new System.Drawing.Point(591, 157);
            this.CONFIRMTOGOTOEDITFORM.Margin = new System.Windows.Forms.Padding(2);
            this.CONFIRMTOGOTOEDITFORM.Name = "CONFIRMTOGOTOEDITFORM";
            this.CONFIRMTOGOTOEDITFORM.Size = new System.Drawing.Size(95, 30);
            this.CONFIRMTOGOTOEDITFORM.TabIndex = 26;
            this.CONFIRMTOGOTOEDITFORM.Text = "Add Constraints";
            this.CONFIRMTOGOTOEDITFORM.UseVisualStyleBackColor = true;
            this.CONFIRMTOGOTOEDITFORM.Click += new System.EventHandler(this.CONFIRMTOGOTOEDITFORM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select the column you want to apply constraints on";
            // 
            // RETURNTOFIRSTPAGE
            // 
            this.RETURNTOFIRSTPAGE.Location = new System.Drawing.Point(420, 311);
            this.RETURNTOFIRSTPAGE.Margin = new System.Windows.Forms.Padding(2);
            this.RETURNTOFIRSTPAGE.Name = "RETURNTOFIRSTPAGE";
            this.RETURNTOFIRSTPAGE.Size = new System.Drawing.Size(184, 46);
            this.RETURNTOFIRSTPAGE.TabIndex = 24;
            this.RETURNTOFIRSTPAGE.Text = "Home";
            this.RETURNTOFIRSTPAGE.UseVisualStyleBackColor = true;
            this.RETURNTOFIRSTPAGE.Click += new System.EventHandler(this.RETURNTOFIRSTPAGE_Click);
            // 
            // THEORDEROFTHECOLUMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 418);
            this.Controls.Add(this.CHOOSECOLUMN);
            this.Controls.Add(this.CONFIRMTOGOTOEDITFORM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RETURNTOFIRSTPAGE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "THEORDEROFTHECOLUMN";
            this.Text = "Choose the order of the column";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CHOOSECOLUMN;
        public System.Windows.Forms.Button CONFIRMTOGOTOEDITFORM;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button RETURNTOFIRSTPAGE;
    }
}