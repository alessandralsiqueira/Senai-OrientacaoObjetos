using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio.Helpers
{
    public class Comissao
    {
        public double CalcularComissao(double precoUnitario, int quantidadeVendida)
        {
            double resultadoComissao = (quantidadeVendida * precoUnitario) * 0.05;
            return resultadoComissao; 

        }
    }
}
