using Aula7.Pessoas;
using Aula7.Produtos;
using Aula7.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            var venda = new Venda();
            var pessoa = new Pessoa();
            pessoa.Nome = "Jessé";

            var produto = new Produto();
            produto.Descricao = "coca";
            produto.valor = 10;

            venda.Data = DateTime.Now;
            venda.Obs = "";
            venda.pessoa = pessoa;
            venda.produto = produto;
        }
    }
}
