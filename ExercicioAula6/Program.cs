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
                var pessoa = new Pessoa {Nome = Console.ReadLine()};

                pessoas[i] = pessoa;
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
            //Exercicio 5
            /*
            Console.WriteLine("Cadastrando Clientes");

            Console.WriteLine("Quantos clientes deseja cadastrar");
            int qtClientes = int.Parse(Console.ReadLine());
            var clientes = new Cliente[qtClientes];



            for (int i = 0; i < clientes.Length; i++)
            {
                var cliente = new Cliente();
                Console.WriteLine("Informe o Nome do cliente: ");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe a Cidade do cliente: ");
                cliente.Cidade = Console.ReadLine();
                Console.WriteLine("Informe o Bairro do cliente: ");
                cliente.Bairro = Console.ReadLine() ;
                Console.WriteLine("Informe o Estado do cliente: ");
                cliente.Estado = Console.ReadLine();

                clientes[i] = cliente;
            }

            Console.WriteLine("Lista de todos os Clientes: ");
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Nome: " + clientes[i].Nome);
                Console.WriteLine("Cidade: " + clientes[i].Cidade);
                Console.WriteLine("Bairro: " + clientes[i].Bairro);
                Console.WriteLine("Estado: " + clientes[i].Estado);
            }
            /*
            Console.WriteLine("Digite a idade das 10 pessoas");
            int idadeSoma;
            var pessoas = new Pessoa[10];

            for (int i = 0; i < pessoas.Length; i++)
            {
                var pessoa = new Pessoa();
                Console.WriteLine("Digite o Nome da pessoa: ");
                pessoa.Nome = Console.ReadLine() ;
                Console.WriteLine("Digite a Idade da Pessoa: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                pessoas[i] = pessoa;
                //if (pessoas[i].Idade < 18)
                //{
                //    idadeSoma = pessoas[i].Idade;
                //}
            }
            for (int i = 0; i < pessoas.Length; i++)
            {
                if(pessoas[i].Idade < 18)
                {
                    Console.WriteLine("Pessoa " + pessoas[i].Nome + "é menor de idade");
                }
            }*/

            Console.ReadLine();
        }



            
        
    }
}
