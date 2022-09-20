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
            var valorAtualDolar = decimal.Parse(txtDolarHj.Text);
            var valorEmDolar = decimal.Parse(txtValorUsuario.Text);

            var resultado = valorEmDolar * valorAtualDolar;

            MessageBox.Show(txtValorUsuario.Text + " dólar(es), corresponde a " + resultado.ToString() + " reais.");

            //MessageBox.Show("Troca de valores concluída","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDolarHj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtDolarHj.Text);
                DolarHjEhValido = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtDolarHj.Focus();
                DolarHjEhValido = false;
                throw;
            } 


        }

        private void txtValorUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorUsuario.Text);
                ValorUsuarioValido = true;
                if (DolarHjEhValido && ValorUsuarioValido)
                {
                    btnConverter.Enabled = true;
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtValorUsuario.Focus();
                ValorUsuarioValido = false;
                btnConverter.Enabled = false;
                
            }
        }
    }
}
