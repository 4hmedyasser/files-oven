using System;
using System.IO;
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
    public partial class IMPORTINGDATA : Form
    {
        public IMPORTINGDATA()
        {
            InitializeComponent();
        }

        private void GOTOSECONDFORM_Click(object sender, EventArgs e)
        {
            if
            (
                ( string.IsNullOrEmpty(TEXTFILEPATH.Text) || string.IsNullOrEmpty(ROWDELIMITER.Text) || string.IsNullOrEmpty(COLUMNDELIMITER.Text) )
                &&
                string.IsNullOrEmpty(EXCELFILEPATH.Text)
            )
            {
                MessageBox.Show("Please enter all needed information" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(ROWDELIMITER.Text) && string.IsNullOrEmpty(COLUMNDELIMITER.Text))
                {
                    THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
                    Openform.Show();
                    this.Visible = false;
                }
                else
                {
                    Globals.rowDelimiter = ROWDELIMITER.Text[0];
                    Globals.columDelimiter = COLUMNDELIMITER.Text[0];
                    THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
                    Openform.Show();
                    this.Visible = false;
                }
            }
        }

        private void BROWSETEXTFILE_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                string strfilename = OpenFileDialog1.FileName;
                TEXTFILEPATH.Text = strfilename;
                Globals.txtFileName = strfilename;
                Globals.xmlFileName = Path.GetFileNameWithoutExtension(strfilename) + ".xml";
                Globals.getText();
            
            }
        }

        private void BROWSEEXCELFILE_Click(object sender, EventArgs e)
        {
              OpenFileDialog OpenFileDialog2 = new OpenFileDialog();
              if (OpenFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {

                string strfilename1 = OpenFileDialog2.FileName;
                EXCELFILEPATH.Text = strfilename1;
                Globals.xlsxFileName = strfilename1;
                Globals.xmlFileName = Path.GetFileNameWithoutExtension(strfilename1) + ".xml";
                Globals.getExcel();
              }
        }
    }
}
