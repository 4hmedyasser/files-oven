﻿using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GOTOSECONDFORM_Click(object sender, EventArgs e)
        {
            THEORDEROFTHECOLUMN Openform = new THEORDEROFTHECOLUMN();
            Openform.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BROWSETEXTFILE_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                string strfilename = OpenFileDialog1.FileName;
                TXTFILEPATH.Text = strfilename;
            
            
            }
        }

        private void TXTFILEPATH_TextChanged(object sender, EventArgs e)
        {

        }

        private void BROWSEEXCELFILE_Click(object sender, EventArgs e)
        {
              OpenFileDialog OpenFileDialog2 = new OpenFileDialog();
              if (OpenFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {

                  string strfilename1 = OpenFileDialog2.FileName;
                  EXCELFILEPATH.Text = strfilename1;
              }
        }
    }
}
