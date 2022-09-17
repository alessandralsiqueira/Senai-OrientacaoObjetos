namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmCotacaoDolar
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
            this.lblDolarHoje = new System.Windows.Forms.Label();
            this.lblValorUsuario = new System.Windows.Forms.Label();
            this.txtDolarHj = new System.Windows.Forms.TextBox();
            this.txtValorUsuario = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDolarHoje
            // 
            this.lblDolarHoje.AutoSize = true;
            this.lblDolarHoje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDolarHoje.Location = new System.Drawing.Point(12, 34);
            this.lblDolarHoje.Name = "lblDolarHoje";
            this.lblDolarHoje.Size = new System.Drawing.Size(179, 19);
            this.lblDolarHoje.TabIndex = 0;
            this.lblDolarHoje.Text = "Digite o valor do dólar hoje:";
            this.lblDolarHoje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorUsuario
            // 
            this.lblValorUsuario.AutoSize = true;
            this.lblValorUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUsuario.Location = new System.Drawing.Point(12, 70);
            this.lblValorUsuario.Name = "lblValorUsuario";
            this.lblValorUsuario.Size = new System.Drawing.Size(225, 19);
            this.lblValorUsuario.TabIndex = 1;
            this.lblValorUsuario.Text = "Digite o valor que deseja converter:";
            // 
            // txtDolarHj
            // 
            this.txtDolarHj.Location = new System.Drawing.Point(188, 30);
            this.txtDolarHj.Name = "txtDolarHj";
            this.txtDolarHj.Size = new System.Drawing.Size(115, 23);
            this.txtDolarHj.TabIndex = 2;
            // 
            // txtValorUsuario
            // 
            this.txtValorUsuario.Location = new System.Drawing.Point(234, 69);
            this.txtValorUsuario.Name = "txtValorUsuario";
            this.txtValorUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtValorUsuario.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(24, 168);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(122, 49);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.UseWaitCursor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 274);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorUsuario);
            this.Controls.Add(this.txtDolarHj);
            this.Controls.Add(this.lblValorUsuario);
            this.Controls.Add(this.lblDolarHoje);
            this.Name = "frmCotacaoDolar";
            this.Text = "Cotação do Dólar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDolarHoje;
        private Label lblValorUsuario;
        private TextBox txtDolarHj;
        private TextBox txtValorUsuario;
        private Button btnConverter;
    }
}