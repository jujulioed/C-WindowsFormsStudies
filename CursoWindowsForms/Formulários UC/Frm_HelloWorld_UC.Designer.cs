
namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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
            this.Txt_InputLabel = new System.Windows.Forms.TextBox();
            this.Btn_ModifiesLabel = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_InputLabel
            // 
            this.Txt_InputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_InputLabel.Location = new System.Drawing.Point(19, 70);
            this.Txt_InputLabel.Name = "Txt_InputLabel";
            this.Txt_InputLabel.Size = new System.Drawing.Size(390, 20);
            this.Txt_InputLabel.TabIndex = 6;
            // 
            // Btn_ModifiesLabel
            // 
            this.Btn_ModifiesLabel.Location = new System.Drawing.Point(19, 41);
            this.Btn_ModifiesLabel.Name = "Btn_ModifiesLabel";
            this.Btn_ModifiesLabel.Size = new System.Drawing.Size(175, 23);
            this.Btn_ModifiesLabel.TabIndex = 5;
            this.Btn_ModifiesLabel.Text = "Modifies the lable";
            this.Btn_ModifiesLabel.UseVisualStyleBackColor = true;
            this.Btn_ModifiesLabel.Click += new System.EventHandler(this.Btn_ModifiesLabel_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AccessibleName = "";
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(14, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(245, 25);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Visual Studio .NET version";
            // 
            // Frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_InputLabel);
            this.Controls.Add(this.Btn_ModifiesLabel);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(426, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_InputLabel;
        private System.Windows.Forms.Button Btn_ModifiesLabel;
        private System.Windows.Forms.Label lbl_Title;
    }
}
