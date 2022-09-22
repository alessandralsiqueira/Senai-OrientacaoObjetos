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
            this.lblValorUsuario = new System.Windows.Forms.Label();
            this.txtValorUsuario = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorUsuario
            // 
            this.lblValorUsuario.AutoSize = true;
            this.lblValorUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUsuario.Location = new System.Drawing.Point(11, 26);
            this.lblValorUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorUsuario.Name = "lblValorUsuario";
            this.lblValorUsuario.Size = new System.Drawing.Size(225, 19);
            this.lblValorUsuario.TabIndex = 1;
            this.lblValorUsuario.Text = "Digite o valor que deseja converter:";
            // 
            // txtValorUsuario
            // 
            this.txtValorUsuario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValorUsuario.Location = new System.Drawing.Point(25, 50);
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
            this.btnConverter.Location = new System.Drawing.Point(11, 113);
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
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorUsuario);
            this.Controls.Add(this.lblValorUsuario);
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
        private Label lblValorUsuario;
        private TextBox txtValorUsuario;
        private Button btnConverter;
        private TextBox textBox1;
    }
}