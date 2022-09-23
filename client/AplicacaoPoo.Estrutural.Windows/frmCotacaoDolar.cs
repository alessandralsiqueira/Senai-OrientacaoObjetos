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
    public partial class frmCotacaoDolar : Form
    {
       
        public frmCotacaoDolar()
        {
            InitializeComponent();

            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
        }

        private void txtValorUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorUsuario.Text == "") return;
                
                var valorEmDolar = decimal.Parse(txtValorUsuario.Text);

                var moeda = new ConverterMoedaService();
                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtValorUsuario.Focus();
                

            }

        }
        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}