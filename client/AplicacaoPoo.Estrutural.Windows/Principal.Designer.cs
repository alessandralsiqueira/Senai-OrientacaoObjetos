namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(12, 136);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(117, 38);
            this.btnDolar.TabIndex = 0;
            this.btnDolar.Text = "Cotação do Dólar";
            this.btnDolar.UseVisualStyleBackColor = true;
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(191, 136);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(127, 38);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "Comissão de Vendas";
            this.btnComissao.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 240);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnDolar);
            this.Name = "frmPrincipal";
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDolar;
        private Button btnComissao;
    }
} 