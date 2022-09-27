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

            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;
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


                if (txtValorUsuario.Text == "") return;

                var valorEmEuro = decimal.Parse(txtValorUsuario.Text);

                var moedaEuro = new ConverterMoedaService();
                var resultadoEuro = moedaEuro.ConverterEuroEmReal(valorEmEuro);
                lblPrimeiroValor.Text = $"{valorEmEuro} {MoedaHelper.Euro} igual a";
                lblSegundoValor.Text = $"{resultadoEuro} {MoedaHelper.Real}"; 
                
                if (txtValorUsuario.Text == "") return;

                var valorEmLibra = decimal.Parse(txtValorUsuario.Text);

                var moedaLibra = new ConverterMoedaService();
                var resultadoLibra = moedaLibra.ConverterLibraEmReal(valorEmLibra);
                lblPrimeiroValor.Text = $"{valorEmLibra} {MoedaHelper.Libra} igual a";
                lblSegundoValor.Text = $"{resultadoLibra} {MoedaHelper.Real}";

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor decimal.");
                txtValorUsuario.Focus();

            }

        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region MEU PROGRAMA
            //Atalho para comentar código CTRL + K + C
            //Atalho para descomentar o código CTRL + K +U

            if (txtValorUsuario.Text == "") return; 
            var moedaService = new ConverterMoedaService();
            decimal valorEmDolar = decimal.Parse(txtValorUsuario.Text);
            var valorEmEuro = decimal.Parse(txtValorUsuario.Text);
            var valorEmLibra = decimal.Parse(txtValorUsuario.Text);

            switch (cmbMoedas.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(valorEmEuro);
                        lblPrimeiroValor.Text = $"{valorEmEuro} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Libra:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(valorEmLibra);
                        lblPrimeiroValor.Text = $"{valorEmLibra} {MoedaHelper.Libra} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                default:
                    break; 

            }
            #endregion
        } 
    }
}