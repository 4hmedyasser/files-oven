namespace ImportingApplyingModel
{
    partial class EDITCOLUMN
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
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE = new System.Windows.Forms.Button();
            this.RETURNTOSELECTANOTHERCOLUMNORDER = new System.Windows.Forms.Button();
            this.ISNULL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HASDEFAULTVALUE = new System.Windows.Forms.CheckBox();
            this.SELECTTHEDEFAULTVALUE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HASUNIQUEVALUE = new System.Windows.Forms.CheckBox();
            this.FIRSTCONDITION = new System.Windows.Forms.ComboBox();
            this.FIRSTNUMBERSELECTEDASCONDITION = new System.Windows.Forms.TextBox();
            this.SECONDCONDITION = new System.Windows.Forms.ComboBox();
            this.SECONDNUMBERSELECTEDASACONDITION = new System.Windows.Forms.TextBox();
            this.ENDSELECTION = new System.Windows.Forms.Button();
            this.HASCERTAINCONDITION = new System.Windows.Forms.CheckBox();
            this.FIRSTOPERATION = new System.Windows.Forms.CheckBox();
            this.SECONDOPERATION = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RETURNFROMEDITCOLUMNTOHOMEPAGE
            // 
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Location = new System.Drawing.Point(98, 369);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Margin = new System.Windows.Forms.Padding(2);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Name = "RETURNFROMEDITCOLUMNTOHOMEPAGE";
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Size = new System.Drawing.Size(139, 46);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.TabIndex = 0;
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Text = "Home";
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.UseVisualStyleBackColor = true;
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Click += new System.EventHandler(this.button1_Click);
            // 
            // RETURNTOSELECTANOTHERCOLUMNORDER
            // 
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Location = new System.Drawing.Point(392, 369);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Margin = new System.Windows.Forms.Padding(2);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Name = "RETURNTOSELECTANOTHERCOLUMNORDER";
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Size = new System.Drawing.Size(129, 46);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.TabIndex = 1;
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Text = "Apply Constraints";
            this.RETURNTOSELECTANOTHERCOLUMNORDER.UseVisualStyleBackColor = true;
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Click += new System.EventHandler(this.button2_Click);
            // 
            // ISNULL
            // 
            this.ISNULL.AutoSize = true;
            this.ISNULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISNULL.Location = new System.Drawing.Point(123, 63);
            this.ISNULL.Margin = new System.Windows.Forms.Padding(2);
            this.ISNULL.Name = "ISNULL";
            this.ISNULL.Size = new System.Drawing.Size(176, 30);
            this.ISNULL.TabIndex = 2;
            this.ISNULL.Text = "No Null Values";
            this.ISNULL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Column you Have Choosen";
            // 
            // HASDEFAULTVALUE
            // 
            this.HASDEFAULTVALUE.AutoSize = true;
            this.HASDEFAULTVALUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASDEFAULTVALUE.Location = new System.Drawing.Point(123, 119);
            this.HASDEFAULTVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.HASDEFAULTVALUE.Name = "HASDEFAULTVALUE";
            this.HASDEFAULTVALUE.Size = new System.Drawing.Size(419, 30);
            this.HASDEFAULTVALUE.TabIndex = 5;
            this.HASDEFAULTVALUE.Text = " Default Value for Replacing Null Values";
            this.HASDEFAULTVALUE.UseVisualStyleBackColor = true;
            // 
            // SELECTTHEDEFAULTVALUE
            // 
            this.SELECTTHEDEFAULTVALUE.Location = new System.Drawing.Point(604, 127);
            this.SELECTTHEDEFAULTVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.SELECTTHEDEFAULTVALUE.Name = "SELECTTHEDEFAULTVALUE";
            this.SELECTTHEDEFAULTVALUE.Size = new System.Drawing.Size(129, 20);
            this.SELECTTHEDEFAULTVALUE.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter the default value ";
            // 
            // HASUNIQUEVALUE
            // 
            this.HASUNIQUEVALUE.AutoSize = true;
            this.HASUNIQUEVALUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASUNIQUEVALUE.Location = new System.Drawing.Point(123, 170);
            this.HASUNIQUEVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.HASUNIQUEVALUE.Name = "HASUNIQUEVALUE";
            this.HASUNIQUEVALUE.Size = new System.Drawing.Size(213, 30);
            this.HASUNIQUEVALUE.TabIndex = 9;
            this.HASUNIQUEVALUE.Text = "Only Unique Value";
            this.HASUNIQUEVALUE.UseVisualStyleBackColor = true;
            this.HASUNIQUEVALUE.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // FIRSTCONDITION
            // 
            this.FIRSTCONDITION.FormattingEnabled = true;
            this.FIRSTCONDITION.Items.AddRange(new object[] {
            "greater than",
            "greater than or equal",
            "less than ",
            "less than or equal ",
            "equal ",
            "not equal"});
            this.FIRSTCONDITION.Location = new System.Drawing.Point(244, 268);
            this.FIRSTCONDITION.Margin = new System.Windows.Forms.Padding(2);
            this.FIRSTCONDITION.Name = "FIRSTCONDITION";
            this.FIRSTCONDITION.Size = new System.Drawing.Size(92, 21);
            this.FIRSTCONDITION.TabIndex = 60;
            this.FIRSTCONDITION.Text = "greater than";
            this.FIRSTCONDITION.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FIRSTNUMBERSELECTEDASCONDITION
            // 
            this.FIRSTNUMBERSELECTEDASCONDITION.Location = new System.Drawing.Point(359, 269);
            this.FIRSTNUMBERSELECTEDASCONDITION.Margin = new System.Windows.Forms.Padding(2);
            this.FIRSTNUMBERSELECTEDASCONDITION.Name = "FIRSTNUMBERSELECTEDASCONDITION";
            this.FIRSTNUMBERSELECTEDASCONDITION.Size = new System.Drawing.Size(92, 20);
            this.FIRSTNUMBERSELECTEDASCONDITION.TabIndex = 61;
            // 
            // SECONDCONDITION
            // 
            this.SECONDCONDITION.FormattingEnabled = true;
            this.SECONDCONDITION.Items.AddRange(new object[] {
            "greater than",
            "greater than or equal ",
            "less than",
            "less than or equal  ",
            "equal ",
            "not equal"});
            this.SECONDCONDITION.Location = new System.Drawing.Point(244, 301);
            this.SECONDCONDITION.Margin = new System.Windows.Forms.Padding(2);
            this.SECONDCONDITION.Name = "SECONDCONDITION";
            this.SECONDCONDITION.Size = new System.Drawing.Size(92, 21);
            this.SECONDCONDITION.TabIndex = 80;
            this.SECONDCONDITION.Text = "greater than";
            // 
            // SECONDNUMBERSELECTEDASACONDITION
            // 
            this.SECONDNUMBERSELECTEDASACONDITION.Location = new System.Drawing.Point(359, 304);
            this.SECONDNUMBERSELECTEDASACONDITION.Margin = new System.Windows.Forms.Padding(2);
            this.SECONDNUMBERSELECTEDASACONDITION.Name = "SECONDNUMBERSELECTEDASACONDITION";
            this.SECONDNUMBERSELECTEDASACONDITION.Size = new System.Drawing.Size(92, 20);
            this.SECONDNUMBERSELECTEDASACONDITION.TabIndex = 84;
            // 
            // ENDSELECTION
            // 
            this.ENDSELECTION.Location = new System.Drawing.Point(668, 369);
            this.ENDSELECTION.Margin = new System.Windows.Forms.Padding(2);
            this.ENDSELECTION.Name = "ENDSELECTION";
            this.ENDSELECTION.Size = new System.Drawing.Size(118, 46);
            this.ENDSELECTION.TabIndex = 86;
            this.ENDSELECTION.Text = "Exit";
            this.ENDSELECTION.UseVisualStyleBackColor = true;
            this.ENDSELECTION.Click += new System.EventHandler(this.ENDSELECTION_Click);
            // 
            // HASCERTAINCONDITION
            // 
            this.HASCERTAINCONDITION.AutoSize = true;
            this.HASCERTAINCONDITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASCERTAINCONDITION.Location = new System.Drawing.Point(123, 226);
            this.HASCERTAINCONDITION.Name = "HASCERTAINCONDITION";
            this.HASCERTAINCONDITION.Size = new System.Drawing.Size(306, 29);
            this.HASCERTAINCONDITION.TabIndex = 87;
            this.HASCERTAINCONDITION.Text = "Certain Value Size or Length";
            this.HASCERTAINCONDITION.UseVisualStyleBackColor = true;
            // 
            // FIRSTOPERATION
            // 
            this.FIRSTOPERATION.AutoSize = true;
            this.FIRSTOPERATION.Location = new System.Drawing.Point(211, 271);
            this.FIRSTOPERATION.Name = "FIRSTOPERATION";
            this.FIRSTOPERATION.Size = new System.Drawing.Size(29, 17);
            this.FIRSTOPERATION.TabIndex = 88;
            this.FIRSTOPERATION.Text = " ";
            this.FIRSTOPERATION.UseVisualStyleBackColor = true;
            // 
            // SECONDOPERATION
            // 
            this.SECONDOPERATION.AutoSize = true;
            this.SECONDOPERATION.Location = new System.Drawing.Point(211, 304);
            this.SECONDOPERATION.Name = "SECONDOPERATION";
            this.SECONDOPERATION.Size = new System.Drawing.Size(29, 17);
            this.SECONDOPERATION.TabIndex = 89;
            this.SECONDOPERATION.Text = " ";
            this.SECONDOPERATION.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(457, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 90;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Literal Values";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(557, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 91;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Numerical Values";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EDITCOLUMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 432);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SECONDOPERATION);
            this.Controls.Add(this.FIRSTOPERATION);
            this.Controls.Add(this.HASCERTAINCONDITION);
            this.Controls.Add(this.ENDSELECTION);
            this.Controls.Add(this.SECONDNUMBERSELECTEDASACONDITION);
            this.Controls.Add(this.SECONDCONDITION);
            this.Controls.Add(this.FIRSTNUMBERSELECTEDASCONDITION);
            this.Controls.Add(this.FIRSTCONDITION);
            this.Controls.Add(this.HASUNIQUEVALUE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SELECTTHEDEFAULTVALUE);
            this.Controls.Add(this.HASDEFAULTVALUE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISNULL);
            this.Controls.Add(this.RETURNTOSELECTANOTHERCOLUMNORDER);
            this.Controls.Add(this.RETURNFROMEDITCOLUMNTOHOMEPAGE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EDITCOLUMN";
            this.Text = "Edit Column";
            this.Load += new System.EventHandler(this.EDITCOLUMN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox ISNULL;
        public System.Windows.Forms.CheckBox HASDEFAULTVALUE;
        public System.Windows.Forms.Button RETURNFROMEDITCOLUMNTOHOMEPAGE;
        public System.Windows.Forms.Button RETURNTOSELECTANOTHERCOLUMNORDER;
        public System.Windows.Forms.TextBox SELECTTHEDEFAULTVALUE;
        public System.Windows.Forms.CheckBox HASUNIQUEVALUE;
        public System.Windows.Forms.ComboBox FIRSTCONDITION;
        public System.Windows.Forms.TextBox FIRSTNUMBERSELECTEDASCONDITION;
        public System.Windows.Forms.ComboBox SECONDCONDITION;
        public System.Windows.Forms.TextBox SECONDNUMBERSELECTEDASACONDITION;
        public System.Windows.Forms.Button ENDSELECTION;
        private System.Windows.Forms.CheckBox HASCERTAINCONDITION;
        private System.Windows.Forms.CheckBox FIRSTOPERATION;
        private System.Windows.Forms.CheckBox SECONDOPERATION;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}