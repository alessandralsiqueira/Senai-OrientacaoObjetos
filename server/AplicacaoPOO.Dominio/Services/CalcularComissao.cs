using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio.Services
{
    public class CalcularComissao
    {
        double valorProduto;
        double qntdVendida;
        double comissao;


        public double CalcularComissaoVendas(double valor)
        {
            return valorProduto * qntdVendida;
        }

        
    }
}
