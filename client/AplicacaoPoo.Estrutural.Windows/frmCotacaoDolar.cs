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
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorAtualDolar = decimal.Parse(txtDolarHj.Text);
            var valorEmDolar = decimal.Parse(txtValorUsuario.Text);

            var resultado = valorEmDolar * valorAtualDolar;

            MessageBox.Show(txtValorUsuario.Text + " dólar(es), corresponde a " + resultado.ToString() + " reais.");

            //MessageBox.Show("Troca de valores concluída","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
