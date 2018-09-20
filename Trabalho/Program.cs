using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        { /*
            -Fazer um algoritmo para Incluir, Alterar, Consultar e Imprimir Todos os Produtos.
            - O sistema deve ter as opções 1 - Incluir, 2 - Alterar, 3 - Consultar, 4 - Imprimir todos ,  0 - Sair
            - O produto deve ter os campos Codigo, Descricao e Valor(Todos podem ser String)
            -A opção de Incluir deve ler os campos dos produtos e incluir na matriz(Não precisa tratar duplicidade)
            - A opção de Alterar deve perguntar o código do produto que deseja alterar e ler os campos,  
                ser persistido na matriz e na posição onde está o produto.(O código não deve ser alterardo)

            - A opção de Consultar deve ler o codigo do produto e Escrever na tela todos os campos do produto
            - A opção de Imprimir Todos deve escrever na tela todos os produtos da lista
            -A opção de Sair deve fechar o sistema*/

            const int codigo = 0;
            const int descricao = 1;
            const int valor = 2;
            int codigoConstante = 0;
            int alteraproduto = 0;
            int qtProdutos = 0;

            string[,] produtos = new string[1000, 3];

            string opcao = "0";

            while (opcao != "")
            {
                
                Console.WriteLine("Selecione uma opção para realizar: \n 1 - Incluir \n 2 - Alterar \n 3 - Consultar \n 4 - Imprimir todos \n 0 - Sair ");
                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                     
                    case "1":
                        
                            Console.Clear();
                            
                            Console.WriteLine("Você está inserindo um produto");
                        
                           /* for (int i = 0; i < qtProdutos; i++)
                            {
                                Console.WriteLine("Informe o Codigo do Produto: ");
                                produtos[i, codigo] = Console.ReadLine();
                                Console.WriteLine("Informe a Descrição do Produto: ");
                                produtos[i, descricao] = Console.ReadLine();
                                Console.WriteLine("Informe o Valor do Produto: ");
                                produtos[i, valor] = Console.ReadLine();

                                if (Convert.ToInt32(produtos[i, codigo]) > 0)
                                {
                                    codigoConstante = Convert.ToInt32(produtos[i, codigo]);
                                }
                            
                            }*/
                        qtProdutos++;
                        Console.WriteLine("Digite qualquer tecla para voltar: ");
                        opcao = Console.ReadLine();
                        Console.Clear();

                        break;
                        
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Você está alterando o Produto");
                        Console.WriteLine("Informe o Codigo do Produto que deseja alterar: ");
                        alteraproduto = int.Parse(Console.ReadLine());

                        if (alteraproduto == codigoConstante)
                        {
                            for (int i = 0; i < produtos.GetLength(0); i++)
                            {

                                Console.WriteLine("Codigo do produto" + (produtos[i, codigo] = produtos[i, codigo]));
                                Console.WriteLine("Informe a Descrição do Produto: ");
                                produtos[i, descricao] = Console.ReadLine();
                                Console.WriteLine("Informe o Valor do Produto: ");
                                produtos[i, valor] = Console.ReadLine();
                            }
                        }

                        Console.WriteLine("Digite qualquer tecla para voltar: ");
                        opcao = Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":

                        Console.Clear();
                        Console.WriteLine("Informe o produto que deseja Consultar: ");
                        alteraproduto = int.Parse(Console.ReadLine());

                        if (alteraproduto == codigoConstante)
                        {
                            for (int i = 0; i < produtos.GetLength(0); i++)
                            {
                                Console.WriteLine("Codigo: " + produtos[i, codigo] + " | " +
                                    " descrição: " + produtos[i, descricao] + " | " +
                                    " Valor do produto: " + produtos[i, valor]);
                                
                            }
                        }
                        Console.WriteLine("Digite qualquer tecla para voltar: ");
                        opcao = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        for (int i = 0; i < qtProdutos; i++)
                        {
                            Console.WriteLine("Codigo: " + produtos[i, codigo] + " | " +
                                              " Descrição: " + produtos[i, descricao] + " | " +
                                              " Valor do produto: " + produtos[i, valor]);
                        }

                        Console.WriteLine("Digite qualquer tecla para voltar: ");
                        opcao = Console.ReadLine();
                        Console.Clear();
                        break;
                    
                        
                    default:
                        opcao = "";
                        break;
                }
            }
        }
     }
}
