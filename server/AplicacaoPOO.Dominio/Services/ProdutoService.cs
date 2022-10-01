using AplicacaoPOO.Dominio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio.Services
{
    public class ProdutoService
    {
        public List<Produto> ListagemProdutosFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                Id = 1,
                Nome = "Produto A",
                ValorUnitario = 10m
            });
            lista.Add(new Produto()
            {
                Id = 1,
                Nome = "Produto B",
                ValorUnitario = 10m
            });
            return lista;
        }
    } 
}
