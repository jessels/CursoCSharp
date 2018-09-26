using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula7.Pessoas;
using Aula7.Produtos;

namespace Aula7.Vendas
{
    class Venda
    {
        public Produto produto { get; set; }

        public Pessoa pessoa { get; set; }

        public DateTime Data { get; set; }

        public string Obs { get; set; }

    }
}
