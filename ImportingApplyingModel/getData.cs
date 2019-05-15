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
        int i, j;

        public getData(String viewMessage , String originalValue , int i, int j)
        {
            this.viewMessage = viewMessage;
            this.originalValue = originalValue;
            this.i = i;
            this.j = j;
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
                MessageBox.Show("Please edit the value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Globals.list[i][j] = AlternativeValue.Text;
                this.Hide();
            }
        }
    }
}
