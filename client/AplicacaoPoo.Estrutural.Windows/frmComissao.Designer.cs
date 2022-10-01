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
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.txtCodigoPc = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.cmbVendedorCadastrado = new System.Windows.Forms.ComboBox();
            this.ltbListaDePecas = new System.Windows.Forms.ListBox();
            this.txtQntdVendas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdVendedor.Location = new System.Drawing.Point(6, 22);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(74, 17);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "Vendedor:";
            // 
            // txtCodigoPc
            // 
            this.txtCodigoPc.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoPc.Location = new System.Drawing.Point(6, 66);
            this.txtCodigoPc.Name = "txtCodigoPc";
            this.txtCodigoPc.PlaceholderText = "Código da Peça";
            this.txtCodigoPc.Size = new System.Drawing.Size(134, 24);
            this.txtCodigoPc.TabIndex = 5;
            this.txtCodigoPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorProduto.Location = new System.Drawing.Point(5, 96);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.PlaceholderText = "Valor Unitário";
            this.txtValorProduto.Size = new System.Drawing.Size(134, 24);
            this.txtValorProduto.TabIndex = 6;
            this.txtValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(5, 215);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(125, 33);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(284, 19);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(82, 24);
            this.mtbData.TabIndex = 9;
            this.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // cmbVendedorCadastrado
            // 
            this.cmbVendedorCadastrado.FormattingEnabled = true;
            this.cmbVendedorCadastrado.Location = new System.Drawing.Point(76, 19);
            this.cmbVendedorCadastrado.Name = "cmbVendedorCadastrado";
            this.cmbVendedorCadastrado.Size = new System.Drawing.Size(192, 24);
            this.cmbVendedorCadastrado.TabIndex = 10;
            // 
            // ltbListaDePecas
            // 
            this.ltbListaDePecas.FormattingEnabled = true;
            this.ltbListaDePecas.ItemHeight = 16;
            this.ltbListaDePecas.Location = new System.Drawing.Point(146, 66);
            this.ltbListaDePecas.Name = "ltbListaDePecas";
            this.ltbListaDePecas.Size = new System.Drawing.Size(260, 132);
            this.ltbListaDePecas.TabIndex = 11;
            // 
            // txtQntdVendas
            // 
            this.txtQntdVendas.Location = new System.Drawing.Point(5, 126);
            this.txtQntdVendas.Name = "txtQntdVendas";
            this.txtQntdVendas.PlaceholderText = "Quantidade";
            this.txtQntdVendas.Size = new System.Drawing.Size(134, 24);
            this.txtQntdVendas.TabIndex = 12;
            this.txtQntdVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.Controls.Add(this.txtQntdVendas);
            this.Controls.Add(this.ltbListaDePecas);
            this.Controls.Add(this.cmbVendedorCadastrado);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtCodigoPc);
            this.Controls.Add(this.lblIdVendedor);
            this.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComissao";
            this.Text = "Comissão de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private TextBox txtCodigoPc;
        private TextBox txtValorProduto;
        private Button btnAdicionar;
        private MaskedTextBox mtbData;
        private ComboBox cmbVendedorCadastrado;
        private ListBox ltbListaDePecas;
        private TextBox txtQntdVendas;
    }
}