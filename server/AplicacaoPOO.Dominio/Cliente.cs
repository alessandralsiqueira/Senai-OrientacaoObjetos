using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Cliente
    {
        string Nome { get; set; }
        string Cpf { get; set; }
        Debito Debito { get; set; }
        Credito Credito { get; set; } 
    }
}

// criar um novo formulario frmCliente, adicionar 4 textbox e 4 label para
// nome, cpf, valor do debito, valor do credito
