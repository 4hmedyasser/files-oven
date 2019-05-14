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
            this.NUMERICALY = new System.Windows.Forms.RadioButton();
            this.LITERALY = new System.Windows.Forms.RadioButton();
            this.HASCERTAINCONDITION = new System.Windows.Forms.CheckBox();
            this.SELECTEDCONDITIONVALUE = new System.Windows.Forms.TextBox();
            this.SELECTCONDITION = new System.Windows.Forms.ComboBox();
            this.HASUNIQUEVALUE = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SELECTTHEDEFAULTVALUE = new System.Windows.Forms.TextBox();
            this.HASDEFAULTVALUE = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ISNULL = new System.Windows.Forms.CheckBox();
            this.RETURNTOSELECTANOTHERCOLUMNORDER = new System.Windows.Forms.Button();
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NUMERICALY
            // 
            this.NUMERICALY.AutoSize = true;
            this.NUMERICALY.Location = new System.Drawing.Point(229, 335);
            this.NUMERICALY.Name = "NUMERICALY";
            this.NUMERICALY.Size = new System.Drawing.Size(107, 17);
            this.NUMERICALY.TabIndex = 105;
            this.NUMERICALY.TabStop = true;
            this.NUMERICALY.Text = "Numerical Values";
            this.NUMERICALY.UseVisualStyleBackColor = true;
            // 
            // LITERALY
            // 
            this.LITERALY.AutoSize = true;
            this.LITERALY.Location = new System.Drawing.Point(229, 312);
            this.LITERALY.Name = "LITERALY";
            this.LITERALY.Size = new System.Drawing.Size(88, 17);
            this.LITERALY.TabIndex = 104;
            this.LITERALY.TabStop = true;
            this.LITERALY.Text = "Literal Values";
            this.LITERALY.UseVisualStyleBackColor = true;
            // 
            // HASCERTAINCONDITION
            // 
            this.HASCERTAINCONDITION.AutoSize = true;
            this.HASCERTAINCONDITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASCERTAINCONDITION.Location = new System.Drawing.Point(141, 270);
            this.HASCERTAINCONDITION.Name = "HASCERTAINCONDITION";
            this.HASCERTAINCONDITION.Size = new System.Drawing.Size(306, 29);
            this.HASCERTAINCONDITION.TabIndex = 103;
            this.HASCERTAINCONDITION.Text = "Certain Value Size or Length";
            this.HASCERTAINCONDITION.UseVisualStyleBackColor = true;
            // 
            // SELECTEDCONDITIONVALUE
            // 
            this.SELECTEDCONDITIONVALUE.Location = new System.Drawing.Point(509, 322);
            this.SELECTEDCONDITIONVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.SELECTEDCONDITIONVALUE.Name = "SELECTEDCONDITIONVALUE";
            this.SELECTEDCONDITIONVALUE.Size = new System.Drawing.Size(59, 20);
            this.SELECTEDCONDITIONVALUE.TabIndex = 101;
            // 
            // SELECTCONDITION
            // 
            this.SELECTCONDITION.FormattingEnabled = true;
            this.SELECTCONDITION.Items.AddRange(new object[] {
            "Equal",
            "NOT Equal",
            "More Than",
            "More Than OR Equal",
            "Less Than",
            "Less Than OR Equal"});
            this.SELECTCONDITION.Location = new System.Drawing.Point(379, 322);
            this.SELECTCONDITION.Margin = new System.Windows.Forms.Padding(2);
            this.SELECTCONDITION.Name = "SELECTCONDITION";
            this.SELECTCONDITION.Size = new System.Drawing.Size(105, 21);
            this.SELECTCONDITION.TabIndex = 100;
            this.SELECTCONDITION.Text = "Select Constraint";
            // 
            // HASUNIQUEVALUE
            // 
            this.HASUNIQUEVALUE.AutoSize = true;
            this.HASUNIQUEVALUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASUNIQUEVALUE.Location = new System.Drawing.Point(141, 214);
            this.HASUNIQUEVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.HASUNIQUEVALUE.Name = "HASUNIQUEVALUE";
            this.HASUNIQUEVALUE.Size = new System.Drawing.Size(213, 30);
            this.HASUNIQUEVALUE.TabIndex = 99;
            this.HASUNIQUEVALUE.Text = "Only Unique Value";
            this.HASUNIQUEVALUE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Enter the default value ";
            // 
            // SELECTTHEDEFAULTVALUE
            // 
            this.SELECTTHEDEFAULTVALUE.Location = new System.Drawing.Point(229, 167);
            this.SELECTTHEDEFAULTVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.SELECTTHEDEFAULTVALUE.Name = "SELECTTHEDEFAULTVALUE";
            this.SELECTTHEDEFAULTVALUE.Size = new System.Drawing.Size(129, 20);
            this.SELECTTHEDEFAULTVALUE.TabIndex = 97;
            // 
            // HASDEFAULTVALUE
            // 
            this.HASDEFAULTVALUE.AutoSize = true;
            this.HASDEFAULTVALUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASDEFAULTVALUE.Location = new System.Drawing.Point(141, 122);
            this.HASDEFAULTVALUE.Margin = new System.Windows.Forms.Padding(2);
            this.HASDEFAULTVALUE.Name = "HASDEFAULTVALUE";
            this.HASDEFAULTVALUE.Size = new System.Drawing.Size(419, 30);
            this.HASDEFAULTVALUE.TabIndex = 96;
            this.HASDEFAULTVALUE.Text = " Default Value for Replacing Null Values";
            this.HASDEFAULTVALUE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 95;
            this.label1.Text = "Set Constraints";
            // 
            // ISNULL
            // 
            this.ISNULL.AutoSize = true;
            this.ISNULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISNULL.Location = new System.Drawing.Point(141, 66);
            this.ISNULL.Margin = new System.Windows.Forms.Padding(2);
            this.ISNULL.Name = "ISNULL";
            this.ISNULL.Size = new System.Drawing.Size(176, 30);
            this.ISNULL.TabIndex = 94;
            this.ISNULL.Text = "No Null Values";
            this.ISNULL.UseVisualStyleBackColor = true;
            // 
            // RETURNTOSELECTANOTHERCOLUMNORDER
            // 
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Location = new System.Drawing.Point(391, 407);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Margin = new System.Windows.Forms.Padding(2);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Name = "RETURNTOSELECTANOTHERCOLUMNORDER";
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Size = new System.Drawing.Size(139, 46);
            this.RETURNTOSELECTANOTHERCOLUMNORDER.TabIndex = 93;
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Text = "Apply";
            this.RETURNTOSELECTANOTHERCOLUMNORDER.UseVisualStyleBackColor = true;
            this.RETURNTOSELECTANOTHERCOLUMNORDER.Click += new System.EventHandler(this.RETURNTOSELECTANOTHERCOLUMNORDER_Click);
            // 
            // RETURNFROMEDITCOLUMNTOHOMEPAGE
            // 
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Location = new System.Drawing.Point(67, 407);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Margin = new System.Windows.Forms.Padding(2);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Name = "RETURNFROMEDITCOLUMNTOHOMEPAGE";
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Size = new System.Drawing.Size(139, 46);
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.TabIndex = 92;
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Text = "Home";
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.UseVisualStyleBackColor = true;
            this.RETURNFROMEDITCOLUMNTOHOMEPAGE.Click += new System.EventHandler(this.RETURNFROMEDITCOLUMNTOHOMEPAGE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 106;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EDITCOLUMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NUMERICALY);
            this.Controls.Add(this.LITERALY);
            this.Controls.Add(this.HASCERTAINCONDITION);
            this.Controls.Add(this.SELECTEDCONDITIONVALUE);
            this.Controls.Add(this.SELECTCONDITION);
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

        private System.Windows.Forms.RadioButton NUMERICALY;
        private System.Windows.Forms.RadioButton LITERALY;
        private System.Windows.Forms.CheckBox HASCERTAINCONDITION;
        public System.Windows.Forms.TextBox SELECTEDCONDITIONVALUE;
        public System.Windows.Forms.ComboBox SELECTCONDITION;
        public System.Windows.Forms.CheckBox HASUNIQUEVALUE;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SELECTTHEDEFAULTVALUE;
        public System.Windows.Forms.CheckBox HASDEFAULTVALUE;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox ISNULL;
        public System.Windows.Forms.Button RETURNTOSELECTANOTHERCOLUMNORDER;
        public System.Windows.Forms.Button RETURNFROMEDITCOLUMNTOHOMEPAGE;
        private System.Windows.Forms.Button button1;
    }
}