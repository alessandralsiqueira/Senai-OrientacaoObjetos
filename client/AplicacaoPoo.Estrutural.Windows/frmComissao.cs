using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorProduto = float.Parse(txtValorProduto.Text);
            double qntdVendida = float.Parse(txtQntd.Text);

            double comissao = (valorProduto * qntdVendida) * 0.05;
            
                //var resultado = (comissao * 0.05).ToString("N");
            

            MessageBox.Show("A comissão foi calculada. Será de " + comissao + " reais.");
        }
    }
}
