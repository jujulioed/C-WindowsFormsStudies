﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ModifiesLabel_Click(object sender, EventArgs e)
        {
            lbl_Title.Text = Txt_InputLabel.Text;
        }

        private void Txt_InputLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
