namespace AplicacaoPOO.Windows
{
    partial class frmCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtClienteCpf = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 65);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(12, 108);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(90, 15);
            this.lblDebito.TabIndex = 2;
            this.lblDebito.Text = "Valor de Débito:";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(12, 147);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(94, 15);
            this.lblCredito.TabIndex = 3;
            this.lblCredito.Text = "Valor de Crédito:";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(52, 19);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(266, 23);
            this.txtClienteNome.TabIndex = 4;
            // 
            // txtClienteCpf
            // 
            this.txtClienteCpf.Location = new System.Drawing.Point(40, 62);
            this.txtClienteCpf.Name = "txtClienteCpf";
            this.txtClienteCpf.Size = new System.Drawing.Size(100, 23);
            this.txtClienteCpf.TabIndex = 5;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(108, 105);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(100, 23);
            this.txtDebito.TabIndex = 6;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(108, 144);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 23);
            this.txtCredito.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(243, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(364, 27);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(87, 15);
            this.lblSaldoInicial.TabIndex = 9;
            this.lblSaldoInicial.Text = "SALDO INICIAL";
            this.lblSaldoInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(396, 46);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoInicialValor.TabIndex = 10;
            this.lblSaldoInicialValor.Text = "0";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(383, 65);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Location = new System.Drawing.Point(396, 90);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoValor.TabIndex = 12;
            this.lblSaldoValor.Text = "0";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 201);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtClienteCpf);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Label lblDebito;
        private Label lblCredito;
        private TextBox txtClienteNome;
        private TextBox txtClienteCpf;
        private TextBox txtDebito;
        private TextBox txtCredito;
        private Button btnCalcular;
        private Label lblSaldoInicial;
        private Label lblSaldoInicialValor;
        private Label lblSaldo;
        private Label lblSaldoValor;
    }
}