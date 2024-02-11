
namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_ModifiesLabel = new System.Windows.Forms.Button();
            this.Txt_InputLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AccessibleName = "";
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(245, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Visual Studio .NET version";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(205, 340);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(190, 50);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "Close the Application";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_ModifiesLabel
            // 
            this.Btn_ModifiesLabel.Location = new System.Drawing.Point(17, 37);
            this.Btn_ModifiesLabel.Name = "Btn_ModifiesLabel";
            this.Btn_ModifiesLabel.Size = new System.Drawing.Size(175, 23);
            this.Btn_ModifiesLabel.TabIndex = 2;
            this.Btn_ModifiesLabel.Text = "Modifies the lable";
            this.Btn_ModifiesLabel.UseVisualStyleBackColor = true;
            this.Btn_ModifiesLabel.Click += new System.EventHandler(this.Btn_ModifiesLabel_Click);
            // 
            // Txt_InputLabel
            // 
            this.Txt_InputLabel.Location = new System.Drawing.Point(17, 66);
            this.Txt_InputLabel.Name = "Txt_InputLabel";
            this.Txt_InputLabel.Size = new System.Drawing.Size(301, 20);
            this.Txt_InputLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.Txt_InputLabel);
            this.Controls.Add(this.Btn_ModifiesLabel);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.lbl_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_ModifiesLabel;
        private System.Windows.Forms.TextBox Txt_InputLabel;
    }
}

