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
    public partial class EDITCOLUMN : Form
    {
        public EDITCOLUMN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
            Openform.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMPORTINGDATA Openform1 = new IMPORTINGDATA();
            Openform1.Show();
            this.Visible = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ENDSELECTION_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EDITCOLUMN_Load(object sender, EventArgs e)
        {

        }
    }
}
