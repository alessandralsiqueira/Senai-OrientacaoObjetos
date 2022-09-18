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
            var valorProduto = decimal.Parse(txtValorProduto.Text);
            var qntdVendida = decimal.Parse(txtQntd.Text);

           // int comissao = decimal.Parse(valorProduto * qntdVendida);

            //MessageBox.Show(comissao.ToString);

            ///MessageBox.Show("Comissão calculada, será de " + comissao.ToString + " reais.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
