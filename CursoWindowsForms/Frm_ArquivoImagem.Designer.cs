﻿
namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.Pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Btn_Font = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            this.Lbl_ArquivoImagem.AutoSize = true;
            this.Lbl_ArquivoImagem.Location = new System.Drawing.Point(41, 30);
            this.Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            this.Lbl_ArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ArquivoImagem.TabIndex = 0;
            this.Lbl_ArquivoImagem.Text = "label1";
            // 
            // Pic_ArquivoImagem
            // 
            this.Pic_ArquivoImagem.Location = new System.Drawing.Point(44, 46);
            this.Pic_ArquivoImagem.Name = "Pic_ArquivoImagem";
            this.Pic_ArquivoImagem.Size = new System.Drawing.Size(319, 145);
            this.Pic_ArquivoImagem.TabIndex = 1;
            this.Pic_ArquivoImagem.TabStop = false;
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Location = new System.Drawing.Point(432, 30);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cor.TabIndex = 2;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Btn_Font
            // 
            this.Btn_Font.Location = new System.Drawing.Point(432, 59);
            this.Btn_Font.Name = "Btn_Font";
            this.Btn_Font.Size = new System.Drawing.Size(75, 23);
            this.Btn_Font.TabIndex = 3;
            this.Btn_Font.Text = "Fonte";
            this.Btn_Font.UseVisualStyleBackColor = true;
            this.Btn_Font.Click += new System.EventHandler(this.Btn_Font_Click);
            // 
            // Frm_ArquivoImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Font);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.Pic_ArquivoImagem);
            this.Controls.Add(this.Lbl_ArquivoImagem);
            this.Name = "Frm_ArquivoImagem";
            this.Size = new System.Drawing.Size(598, 261);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox Pic_ArquivoImagem;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.Button Btn_Font;
    }
}
