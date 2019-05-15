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

        private void Form2_Load(object sender, EventArgs e)
        {
            CHOOSECOLUMN.DataSource = Globals.list[0];
            CHOOSECOLUMN.SelectedIndex = 0;
        }

        private void CONFIRMTOGOTOEDITFORM_Click(object sender, EventArgs e)
        {
            Globals.selectedColumn = CHOOSECOLUMN.SelectedIndex;
            EDITCOLUMN openeditform = new EDITCOLUMN();
            openeditform.Show();
            this.Visible = false;
        }

        private void RETURNTOFIRSTPAGE_Click(object sender, EventArgs e)
        {
            IMPORTINGDATA Openform1 = new IMPORTINGDATA();
            Openform1.Show();
            this.Visible = false;
        }
    }
}
