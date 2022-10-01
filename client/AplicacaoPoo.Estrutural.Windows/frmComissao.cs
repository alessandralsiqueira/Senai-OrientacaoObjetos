using AplicacaoPOO.Dominio.Helpers;
using AplicacaoPOO.Dominio.Services;
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
            var comissao = new Comissao();
            var total = comissao.CalcularComissao; int.Parse(txtValorProduto.Text); int.Parse(txtQntdVendas.Text);
        }

 
        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {

            if (txtValorProduto.Text == "")
            {
                txtValorProduto.Enabled = false;
                return;
            }
            txtValorProduto.Enabled = true;


        }

       

        



    }
}
