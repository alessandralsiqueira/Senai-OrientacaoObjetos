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
            txtValorUsuario.Text = "1";

            //coloca os valores da nossa classe dentro do combobox
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list;
            cmbMoedas.SelectedIndex = 0;
        }

        private void txtValorUsuario_TextChanged(object sender, EventArgs e)
        {
            
                if (txtValorUsuario.Text == "")
                {
                    cmbMoedas.Enabled = false;
                    return;
                }
                cmbMoedas.Enabled = true;
                EfetuarConversaoMoeda();
            
            
        }
            


        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversaoMoeda();
        }


        private void EfetuarConversaoMoeda()
        {
            
            try
            {
                #region Calculo da Conversao
                //Atalho para comentar código CTRL + K + C
                //Atalho para descomentar o código CTRL + K +U

                if (txtValorUsuario.Text == "") return;
                var moedaService = new ConverterMoedaService();
                decimal valorEmDolar = decimal.Parse(txtValorUsuario.Text);
                // var valorEmEuro = decimal.Parse(txtValorUsuario.Text);
                //var valorEmLibra = decimal.Parse(txtValorUsuario.Text);

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
                            var valorConvertido = moedaService.ConverterEuroEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Libra:
                        {
                            var valorConvertido = moedaService.ConverterLibraEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libra} igual a";
                            lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                            break;
                        }
                    default:
                        break;

                }
                #endregion
            }
            catch (Exception)
            {

                MessageBox.Show("Você precisa informar um valor numérico!");
                txtValorUsuario.Text = String.Empty;
                txtValorUsuario.Focus();
            }
        }
    }
}

    
