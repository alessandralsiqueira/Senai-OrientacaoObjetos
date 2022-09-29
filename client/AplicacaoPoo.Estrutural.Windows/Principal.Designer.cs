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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversorDeMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btnDolar.Text = "Conversor de Moedas";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversorDeMoedasToolStripMenuItem,
            this.comissionamentoToolStripMenuItem,
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversorDeMoedasToolStripMenuItem
            // 
            this.conversorDeMoedasToolStripMenuItem.Name = "conversorDeMoedasToolStripMenuItem";
            this.conversorDeMoedasToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.conversorDeMoedasToolStripMenuItem.Text = "Conversor de Moedas";
            this.conversorDeMoedasToolStripMenuItem.Click += new System.EventHandler(this.conversorDeMoedasToolStripMenuItem_Click);
            // 
            // comissionamentoToolStripMenuItem
            // 
            this.comissionamentoToolStripMenuItem.Name = "comissionamentoToolStripMenuItem";
            this.comissionamentoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.comissionamentoToolStripMenuItem.Text = "Comissionamento";
            this.comissionamentoToolStripMenuItem.Click += new System.EventHandler(this.comissionamentoToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "CalculaApps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDolar;
        private Button btnComissao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorDeMoedasToolStripMenuItem;
        private ToolStripMenuItem comissionamentoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
    }
} 