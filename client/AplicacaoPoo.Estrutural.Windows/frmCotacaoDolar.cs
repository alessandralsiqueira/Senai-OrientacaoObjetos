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
            HabilitarOuDesabilitarBotaoCalcularConversao();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtDolarHj.Text);
            var valorEmDolar = decimal.Parse(txtValorUsuario.Text);

            var resultado = valorEmDolar * valorAtualDolar;

            MessageBox.Show(txtValorUsuario.Text + " dólar(es), corresponde a " + resultado.ToString() + " reais.");

        }

        private void txtDolarHj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtDolarHj.Text);
                DolarHjEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtDolarHj.Focus();
                DolarHjEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();
               
            } 

        }

        private void txtValorUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorUsuario.Text);
                ValorUsuarioValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtValorUsuario.Focus();
                ValorUsuarioValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();


            }
        } 
        private void HabilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (DolarHjEhValido && ValorUsuarioValido)
            {
                btnConverter.Enabled = true;
            }
            else
            {
                btnConverter.Enabled = false;
            }
        }
    }
}
