using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportingApplyingModel
{
    public partial class getData : Form
    {
        String viewMessage;
        String originalValue;
        public String Replacement;
        public getData(String viewMessage , String originalValue)
        {
            this.viewMessage = viewMessage;
            this.originalValue = originalValue;
            InitializeComponent();
        }

        private void getData_Load(object sender, EventArgs e)
        {
            MessageLable.Text = viewMessage;
            AlternativeValue.Text = originalValue;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if(AlternativeValue.Text == originalValue || String.IsNullOrEmpty(AlternativeValue.Text))
            {
                MessageBox.Show("Error", "Please edit the value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Replacement = AlternativeValue.Text;
                this.Hide();
            }
        }

        public string getReplacement()
        {
            return Replacement;
        }

    }
}
