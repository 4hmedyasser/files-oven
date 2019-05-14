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

        private void EDITCOLUMN_Load(object sender, EventArgs e)
        {
            SELECTCONDITION.SelectedIndex = 0;
        }

        private void RETURNFROMEDITCOLUMNTOHOMEPAGE_Click(object sender, EventArgs e)
        {
            IMPORTINGDATA openForm1 = new IMPORTINGDATA();
            openForm1.Show();
            this.Hide();
        }

        private void OKANDCHOOSEANOTHERCOLUMN_Click(object sender, EventArgs e)
        {
            Globals.setXML();
            THEORDEROFTHECOLUMN openForm2 = new THEORDEROFTHECOLUMN();
            openForm2.Show();
            this.Hide();
        }

        private void APPLYBEFOREOK_Click(object sender, EventArgs e)
        {
            if (HASDEFAULTVALUE.Checked)
            {
                if (string.IsNullOrEmpty(SELECTTHEDEFAULTVALUE.Text))
                {
                    MessageBox.Show("Please enter the default value you want to apply.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Globals.setDefaultValue(Globals.selectedColumn, SELECTTHEDEFAULTVALUE.Text);
                }
            }
            if (ISNULL.Checked)
            {
                Globals.isNotNull(Globals.selectedColumn);
            }
            if (HASUNIQUEVALUE.Checked)
            {
                Globals.isUnique(Globals.selectedColumn);
            }
            if (HASCERTAINCONDITION.Checked)
            {
                if ((!LITERALY.Checked && !NUMERICALY.Checked) || string.IsNullOrEmpty(SELECTEDCONDITIONVALUE.Text))
                {
                    MessageBox.Show("Please select weather you will apply the constraints on words or numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (LITERALY.Checked)
                    {
                        switch (SELECTCONDITION.SelectedIndex)
                        {
                            case 0:  //  Equal
                                Globals.isEqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            case 1:  //  NOT Equal
                                Globals.isNOTEqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            case 2:  //  More Than
                                Globals.isMoreThan(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            case 3:  //  More Than OR Equal
                                Globals.isMoreThanOREqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            case 4:  //  Less Than
                                Globals.isLessThan(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            case 5:  //  Less Than OR Equal
                                Globals.isLessThanOREqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), false);
                                break;
                            default:
                                MessageBox.Show("Please select a constraint to apply.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else if (NUMERICALY.Checked)
                    {
                        switch (SELECTCONDITION.SelectedIndex)
                        {
                            case 0:  //  Equal
                                Globals.isEqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            case 1:  //  NOT Equal
                                Globals.isNOTEqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            case 2:  //  More Than
                                Globals.isMoreThan(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            case 3:  //  More Than OR Equal
                                Globals.isMoreThanOREqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            case 4:  //  Less Than
                                Globals.isLessThan(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            case 5:  //  Less Than OR Equal
                                Globals.isLessThanOREqual(Globals.selectedColumn, float.Parse(SELECTEDCONDITIONVALUE.Text), true);
                                break;
                            default:
                                MessageBox.Show("Please select a constraint to apply.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }  //  switch
                    }  //  numbers
                }  //  no errors
            }  //  =!=>>=<<=
        }
    }
}
