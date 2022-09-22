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
        private bool DolarHjEhValido;
        private bool ValorUsuarioValido;
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtValorUsuario.Text);
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            //string interpolation
            MessageBox.Show($"Valor convertido é: {resultado} em dólares.");

        }

        private void txtValorUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtValorUsuario.Text == "")
                {
                    btnConverter.Enabled = false;
                    return;
                } 

                var resultado = decimal.Parse(txtValorUsuario.Text);
                btnConverter.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtValorUsuario.Focus();
                btnConverter.Enabled = false;

            }

        }

    }
}
