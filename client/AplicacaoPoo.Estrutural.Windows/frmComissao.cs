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
            double valorProduto = float.Parse(txtValorProduto.Text);
            double qntdVendida = float.Parse(txtQntdVendas.Text);

            double comissao = (valorProduto * qntdVendida) * 0.05;

            //var resultado = (comissao * 0.05).ToString("N");


            MessageBox.Show("A comissão foi calculada. Será de " + comissao + " reais.");
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

        private void CalculoComissao()
        {
            /*  try
              {
                  #region Calculo da Comissao

                  if (txtValorProduto.Text == "") return;
                  double valorProduto = float.Parse(txtValorProduto.Text);
                  double qntdVendida = float.Parse(txtQntdVendas.Text);

                  double comissao = (valorProduto * qntdVendida) * 0.05;

                  switch ()
                  {
                      case MoedaHelper.Dolar:
                          {
                        
                              break;
                          }
                      case MoedaHelper.Euro:
                          {
                            
                              break;
                          }
                      case MoedaHelper.Libra:
                          {
                         
                              break;
                          }
                      default:
                          break;

                  }
                  #endregion
              }
              catch (Exception)
              {


                  MessageBox.Show("A comissão foi calculada. Será de " + comissao + " reais.");
                  txtValorProduto.Text = String.Empty;
                  txtValorProduto.Focus();
              } */

        }



    }
}
