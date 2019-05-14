namespace ImportingApplyingModel
{
    partial class getData
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
            this.MessageLable = new System.Windows.Forms.Label();
            this.AlternativeValue = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLable
            // 
            this.MessageLable.AutoSize = true;
            this.MessageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLable.Location = new System.Drawing.Point(12, 21);
            this.MessageLable.Name = "MessageLable";
            this.MessageLable.Size = new System.Drawing.Size(56, 13);
            this.MessageLable.TabIndex = 0;
            this.MessageLable.Text = "Message: ";
            // 
            // AlternativeValue
            // 
            this.AlternativeValue.Location = new System.Drawing.Point(129, 82);
            this.AlternativeValue.Name = "AlternativeValue";
            this.AlternativeValue.Size = new System.Drawing.Size(198, 20);
            this.AlternativeValue.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(184, 123);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // getData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 185);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.AlternativeValue);
            this.Controls.Add(this.MessageLable);
            this.Name = "getData";
            this.Text = "Invalid Constraint";
            this.Load += new System.EventHandler(this.getData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLable;
        private System.Windows.Forms.TextBox AlternativeValue;
        private System.Windows.Forms.Button ApplyButton;
    }
}