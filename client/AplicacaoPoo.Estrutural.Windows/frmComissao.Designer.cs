namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComissao));
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCodigoPç = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.lblQntd = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtCodigoPç = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.Location = new System.Drawing.Point(-1, 22);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(89, 19);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "ID Vendedor:";
            // 
            // lblCodigoPç
            // 
            this.lblCodigoPç.AutoSize = true;
            this.lblCodigoPç.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoPç.Location = new System.Drawing.Point(-1, 65);
            this.lblCodigoPç.Name = "lblCodigoPç";
            this.lblCodigoPç.Size = new System.Drawing.Size(130, 19);
            this.lblCodigoPç.TabIndex = 1;
            this.lblCodigoPç.Text = "Código do Produto:";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorProduto.Location = new System.Drawing.Point(-1, 103);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(117, 19);
            this.lblValorProduto.TabIndex = 2;
            this.lblValorProduto.Text = "Valor do Produto:";
            // 
            // lblQntd
            // 
            this.lblQntd.AutoSize = true;
            this.lblQntd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQntd.Location = new System.Drawing.Point(-1, 145);
            this.lblQntd.Name = "lblQntd";
            this.lblQntd.Size = new System.Drawing.Size(137, 19);
            this.lblQntd.TabIndex = 3;
            this.lblQntd.Text = "Quantidade Vendida:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVendedor.Location = new System.Drawing.Point(85, 22);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(159, 27);
            this.txtVendedor.TabIndex = 4;
            // 
            // txtCodigoPç
            // 
            this.txtCodigoPç.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoPç.Location = new System.Drawing.Point(126, 64);
            this.txtCodigoPç.Name = "txtCodigoPç";
            this.txtCodigoPç.Size = new System.Drawing.Size(118, 27);
            this.txtCodigoPç.TabIndex = 5;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorProduto.Location = new System.Drawing.Point(112, 103);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(132, 27);
            this.txtValorProduto.TabIndex = 6;
            // 
            // txtQntd
            // 
            this.txtQntd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQntd.Location = new System.Drawing.Point(132, 140);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQntd.Size = new System.Drawing.Size(112, 27);
            this.txtQntd.TabIndex = 7;
            this.txtQntd.Text = "  ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(12, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(259, 44);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "CALCULAR COMISSÃO";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(288, 260);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQntd);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtCodigoPç);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblQntd);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblCodigoPç);
            this.Controls.Add(this.lblVendedor);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComissao";
            this.Text = "Comissão de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVendedor;
        private Label lblCodigoPç;
        private Label lblValorProduto;
        private Label lblQntd;
        private TextBox txtVendedor;
        private TextBox txtCodigoPç;
        private TextBox txtValorProduto;
        private TextBox txtQntd;
        private Button btnCalcular;
    }
}