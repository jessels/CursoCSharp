using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Exemplo
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            /* string[] nomes;
             nomes = new string[5];

             nomes[0] = "Jessé";
             nomes[1] = "Tiago";
             nomes[2] = "Mauricio";
             nomes[3] = "Jozias";
             nomes[4] = "Tomate";

             for (int i = 0; i < nomes.Length; i++)
             {
                 Console.WriteLine(nomes[i]);

             }*/

            // exercicio 2
            /*
            var somaSalario = 0M;
            Console.WriteLine("Quantas pessoas: ");
            var qtPessoas = int.Parse(Console.ReadLine());
            decimal[] salario;
            salario = new decimal[qtPessoas];

            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Salario: ");
                salario[i] = decimal.Parse(Console.ReadLine());
                           
            }
            for (int i = 0; i < salario.Length; i++)
            {
                somaSalario += salario[i];

            }

            Console.WriteLine("Soma do salario "+ somaSalario);*/

            //Exercicio 3
            /*
            Console.WriteLine("Quantas pessoas: ");
            var qtPessoas = int.Parse(Console.ReadLine());

            int[] idade = new int[qtPessoas];

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Qual a sua idade? ");
                idade[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < idade.Length; i++)
            {
                if (idade[i] >= 18)
                    Console.WriteLine("Idades da Lista "+ idade[i]);
            
        }*/

            //Exercicio 4
            /*
            Console.WriteLine("Quantas pessoas: ");
            var qtPessoas = int.Parse(Console.ReadLine());

            string[] pessoas = new string[qtPessoas];
            string[] topCinco = new string[5];
            

            for (int i = 0; i < pessoas.GetLength(0); i++)
            {
                Console.WriteLine("nome da pessoa");
                pessoas[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                topCinco[i] = pessoas[i];

            }
            for (int i = 0; i < topCinco.Length; i++)
            {
                Console.WriteLine(topCinco[i]);

            }*/


            /* exercicio 5
            const int nome = 0;
            const int cidade = 1;
            const int bairro = 2;
            const int estado = 3;

            Console.WriteLine("Quantos Clientes: ");
            int x = int.Parse(Console.ReadLine());
            string [,] clientes = new string[x, 4];


            for (int i = 0; i < clientes.GetLength(0); i++)
            {
                Console.WriteLine("Nome: ");
                clientes[i, nome] = Console.ReadLine();
                Console.WriteLine("cidade: ");
                clientes[i, cidade] = Console.ReadLine();
                Console.WriteLine("Bairro: ");
                clientes[i, bairro] = Console.ReadLine();
                Console.WriteLine("Estado: ");
                clientes[i, estado] = Console.ReadLine();
            }
            for (int i = 0; i < clientes.GetLength(0); i++)
            {
                Console.WriteLine("Nome: " + clientes[i, nome]);
                Console.WriteLine("Cidade: " + clientes[i, cidade]);
                Console.WriteLine("Bairro: " + clientes[i, bairro]);
                Console.WriteLine("Estado: " + clientes[i, estado]);
            }*/

            //Exercio 6

            const int nome = 0;
            const int idade = 1;
            int menorIdade = 0;
            string[,] pessoas = new string[10, 2];

            for (int i = 0; i < pessoas.GetLength(0); i++)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                pessoas[i, nome] = Console.ReadLine();
                Console.WriteLine("Digite a idade da pessoa: ");
                pessoas[i, idade] = Console.ReadLine();

                if (Convert.ToInt32(pessoas[i, idade]) < menorIdade || i == 0)
                {
                    menorIdade = Convert.ToInt32(pessoas[i, idade]);
                }
            }
            for (int i = 0; i < pessoas.GetLength(0); i++)
            {
                if (Convert.ToInt32(pessoas[i, idade]) < 18)
                {
                    Console.WriteLine(pessoas[i, nome] + " é menor de 18 anos!");
                }
            }

            Console.WriteLine("A menor idade encontrada é :" + menorIdade);
            Console.ReadKey();
        }
    }
}
