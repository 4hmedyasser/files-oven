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
                if (string.IsNullOrEmpty(ROWDELIMITER.Text) && string.IsNullOrEmpty(COLUMNDELIMITER.Text) && string.IsNullOrEmpty(TEXTFILEPATH.Text))
                {
                    Globals.getExcel();
                    THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
                    Openform.Show();
                    this.Visible = false;
                }
                else
                {
                    if(ROWDELIMITER.Text == COLUMNDELIMITER.Text)
                    {
                        MessageBox.Show("Row delimiter can't be the same as the column delimiter. Please edit the text file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (ROWDELIMITER.Text == "\n")
                        {
                            Globals.rowDelimiter = '\n';
                            Globals.columDelimiter = COLUMNDELIMITER.Text[0];
                        }
                        else if (COLUMNDELIMITER.Text == "\n")
                        {
                            Globals.rowDelimiter = ROWDELIMITER.Text[0];
                            Globals.columDelimiter = '\n';
                        }
                        else
                        {
                            Globals.rowDelimiter = ROWDELIMITER.Text[0];
                            Globals.columDelimiter = COLUMNDELIMITER.Text[0];
                        }
                        Globals.getText();
                        Console.WriteLine(Globals.rowDelimiter);
                        Console.WriteLine(Globals.columDelimiter);
                        
                        THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
                        Openform.Show();
                        this.Visible = false;
                    }
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

            }
        }
    }
}
