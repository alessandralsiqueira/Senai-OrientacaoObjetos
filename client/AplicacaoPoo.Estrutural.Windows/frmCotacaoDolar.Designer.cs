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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotacaoDolar));
            this.lblDolarHoje = new System.Windows.Forms.Label();
            this.lblValorUsuario = new System.Windows.Forms.Label();
            this.txtDolarHj = new System.Windows.Forms.TextBox();
            this.txtValorUsuario = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDolarHoje
            // 
            this.lblDolarHoje.AutoSize = true;
            this.lblDolarHoje.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDolarHoje.Location = new System.Drawing.Point(11, 37);
            this.lblDolarHoje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.lblValorUsuario.Location = new System.Drawing.Point(11, 103);
            this.lblValorUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorUsuario.Name = "lblValorUsuario";
            this.lblValorUsuario.Size = new System.Drawing.Size(225, 19);
            this.lblValorUsuario.TabIndex = 1;
            this.lblValorUsuario.Text = "Digite o valor que deseja converter:";
            // 
            // txtDolarHj
            // 
            this.txtDolarHj.Location = new System.Drawing.Point(13, 60);
            this.txtDolarHj.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolarHj.Name = "txtDolarHj";
            this.txtDolarHj.Size = new System.Drawing.Size(147, 27);
            this.txtDolarHj.TabIndex = 2;
            this.txtDolarHj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolarHj.TextChanged += new System.EventHandler(this.txtDolarHj_TextChanged);
            // 
            // txtValorUsuario
            // 
            this.txtValorUsuario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorUsuario.Location = new System.Drawing.Point(13, 127);
            this.txtValorUsuario.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtValorUsuario.Name = "txtValorUsuario";
            this.txtValorUsuario.Size = new System.Drawing.Size(147, 27);
            this.txtValorUsuario.TabIndex = 3;
            this.txtValorUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorUsuario.TextChanged += new System.EventHandler(this.txtValorUsuario_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Location = new System.Drawing.Point(11, 183);
            this.btnConverter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(249, 87);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.UseWaitCursor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 289);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorUsuario);
            this.Controls.Add(this.txtDolarHj);
            this.Controls.Add(this.lblValorUsuario);
            this.Controls.Add(this.lblDolarHoje);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private TextBox textBox1;
    }
}