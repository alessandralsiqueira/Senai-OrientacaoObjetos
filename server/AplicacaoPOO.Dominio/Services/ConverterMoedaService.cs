using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio.Services
{
    //static class c#
    //partial class c#
    //abstract class c#

    //exemplo usando classe instaciada
    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.12m;
        decimal CotacaoEuro = 6.0m;
        decimal CotacaoLibra = 6.15m;
        

        public decimal ConverterDolarEmReal(decimal valor)
        
        {
            return valor * CotacaoDolar;

        }

        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }

        public decimal ConverterLibraEmReal(decimal valor)
        { 
            return valor * CotacaoLibra;
        }

    }  
}
