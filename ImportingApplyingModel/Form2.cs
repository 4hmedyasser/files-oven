using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Collections;


namespace ImportingApplyingModel
{
    public partial class THEORDEROFTHECOLUMN : Form
    {
        public THEORDEROFTHECOLUMN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMPORTINGDATA Openform1 = new IMPORTINGDATA();
            Openform1.Show();
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            passvalues();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDITCOLUMN openeditform = new EDITCOLUMN();
            openeditform.Show();
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHOOSECOLUMN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void passvalues() {

            List<string> intlist = new List<string>();
            intlist.Add("ahmed");
            intlist.Add("ali");
            intlist.Add("omar");
           
            CHOOSECOLUMN.DataSource = intlist;
            CHOOSECOLUMN.SelectedIndex = 0;
            
        
        
        }
        

    }
}
