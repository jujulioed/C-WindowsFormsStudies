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
    public partial class Frm_ArquivoImagem : UserControl
    {
        public Frm_ArquivoImagem(string nomeArquivoImage)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImage;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImage);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new ColorDialog();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = CDb.Color;
            }

        }

        private void Btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new FontDialog();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = FDb.Font;
            }
        }
    }
}
