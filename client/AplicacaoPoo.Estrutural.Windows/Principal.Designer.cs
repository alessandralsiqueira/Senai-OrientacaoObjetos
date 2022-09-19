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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDolar
            // 
            this.btnDolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDolar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDolar.Image = ((System.Drawing.Image)(resources.GetObject("btnDolar.Image")));
            this.btnDolar.Location = new System.Drawing.Point(12, 36);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(151, 162);
            this.btnDolar.TabIndex = 0;
            this.btnDolar.Text = "Cotação do Dólar";
            this.btnDolar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnAbrirFormDolar_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComissao.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComissao.Image = ((System.Drawing.Image)(resources.GetObject("btnComissao.Image")));
            this.btnComissao.Location = new System.Drawing.Point(169, 36);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(151, 162);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "Comissão de Vendas";
            this.btnComissao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComissao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnAbrirFormComissao_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(334, 240);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnDolar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "CalculaApps";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDolar;
        private Button btnComissao;
    }
} 