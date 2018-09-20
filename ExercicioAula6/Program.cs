using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula6
{
    class Program
    {
        static void Main(string[] args)
        {


            // var pessoas = new Pessoa[5];
            /* Exercicio 1 com classes
             * 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um nome");
                pessoas[i] = new Pessoa {Nome = Console.ReadLine()};
            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pessoas[i].Nome);
            }*/
            /* Exemplo 2
            var somaSalario = 0M;
            Console.WriteLine("Informe a quantidade de Pessoas");
            int qtPessoas = int.Parse(Console.ReadLine());


            var pessoas = new Pessoa[qtPessoas];
            for (int i = 0; i < qtPessoas; i++)
            {
                Console.WriteLine("Informe o Nome da pessoa");
                pessoas[i] = new Pessoa {Nome = Console.ReadLine() };
                Console.WriteLine("Informe o Salario da Pessoa: ");
                pessoas[i] = new Pessoa { Salario = decimal.Parse(Console.ReadLine()) };
                
            }
            for (int i = 0; i < pessoas.Length; i++)
            {

                somaSalario += pessoas[i].Salario;

            }
            Console.WriteLine("Soma do Salario: " + somaSalario);*/
            /*int qtPessoas;
             * Exercicio 3

            Console.WriteLine("Informe a quantidade de Pessoas");
            qtPessoas = int.Parse(Console.ReadLine());

            var pessoas = new Pessoa[qtPessoas];

            for (int i = 0; i < qtPessoas; i++)
            {
                Console.WriteLine("Informe o Nome da pessoa");
                pessoas[i] = new Pessoa { Nome = Console.ReadLine() };
                Console.WriteLine("Informe o Salario da Pessoa: ");
                pessoas[i] = new Pessoa { Salario = decimal.Parse(Console.ReadLine()) };
                Console.WriteLine("Informe a Idade da Pessoa: ");
                pessoas[i] = new Pessoa { Idade = int.Parse(Console.ReadLine()) };

            }

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade >= 18)
                {
                    Console.WriteLine("Idade: " + pessoas[i].Idade);
                }

            }*/
            /* Exercicio 4
            int qtPessoas;

            Console.WriteLine("Informe a quantidade de Pessoas");
            qtPessoas = int.Parse(Console.ReadLine());
            var topCinco = new String[5];
            var pessoas = new Pessoa[qtPessoas];
            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Informe o nome da pessoa: ");
                pessoas[i] = new Pessoa { Nome = Console.ReadLine() };

            }
            for (int i = 0; i < 5; i++)
            {
                topCinco[i] = pessoas[i].Nome;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(topCinco[i]);
            }*/

            Console.WriteLine("Cadastrando Clientes");

            Console.WriteLine("Quantos clientes deseja cadastrar");
            int qtClientes = int.Parse(Console.ReadLine());
            var clientes = new Cliente[qtClientes];



            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Informe o Nome do cliente: ");
                clientes[i] = new Cliente { Nome = Console.ReadLine() };
                Console.WriteLine("Informe a Cidade do cliente: ");
                clientes[i] = new Cliente { Cidade = Console.ReadLine() };
                Console.WriteLine("Informe o Bairro do cliente: ");
                clientes[i] = new Cliente { Bairro = Console.ReadLine() };
                Console.WriteLine("Informe o Estado do cliente: ");
                clientes[i] = new Cliente { Estado = Console.ReadLine() };
            }

            Console.WriteLine("Lista de todos os Clientes: ");
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Nome: " + clientes[i].Nome);
                Console.WriteLine("Cidade: " + clientes[i].Cidade);
                Console.WriteLine("Bairro: " + clientes[i].Bairro);
                Console.WriteLine("Estado: " + clientes[i].Estado);
            }

            Console.ReadLine();
        }



            
        
    }
}
