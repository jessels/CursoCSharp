using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Exercicio 1
                        Console.WriteLine("digite a operação matemática");
                        string operacaoMatematica = Console.ReadLine();

                        switch (operacaoMatematica)
                        {
                            case "+":
                                Console.WriteLine("Operação de Soma");
                                break;
                            case "-":
                                Console.WriteLine("Operação de subtração");
                                break;
                            case "*":
                                Console.WriteLine("Operação de multiplicação");
                                break;
                            case "/":
                                Console.WriteLine("Operação de Divisão");
                                break;
                            default:
                                Console.WriteLine("operação invalida");
                                break;
                        }*/
            //Exercicio 2
            /*
            Console.WriteLine("Qual a sua aliquota de Imposto de Renda?");
            var aliquotaImposto = decimal.Parse(Console.ReadLine());

            switch(aliquotaImposto)
                {
                case 0:
                    Console.WriteLine("Base de calculo é de R$1903,98");
                    break;
                case 7.5M:
                    Console.WriteLine("Base de calculo é de R$1903,99 até 2826,65");
                    break;
                case 15M:
                    Console.WriteLine("Base de calculo é de 2826,66 até 3751,05");
                    break;
                case 22.5M:
                    Console.WriteLine("Base de calculo é de 3751,06 até 4664,68");
                    break;
                case 27.5M:
                    Console.WriteLine("Base de calculo é acima de 4664,69");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;

            }*/
            //--------------------------Exercicio 3
            /*
            Console.WriteLine("Digite um valor Inteiro: ");
            var numeroInteiro = int.Parse(Console.ReadLine());

            while(numeroInteiro != 0)
            {
                Console.WriteLine(numeroInteiro--);
            }*/

            /*
             --------------------------Exercicio 4 
            var numero = 0;
            while (numero <= 100)
            {
                Console.WriteLine("Continuar S ou N");
                var interacao = Console.ReadLine();
                if (interacao == "s")
                {
                    Console.WriteLine(numero++);
                    continue;
                }else
                Console.WriteLine(numero++);
                break;

            }*/
            //Exercicio 5
            /*
            Console.WriteLine("Quantas pessoas participaram da pesquisa");
            var qtPesquisa = int.Parse(Console.ReadLine());
            var idade = 0;
            var idadeSoma = 0;

            for (int i = 0; i< qtPesquisa ; i++)
            {
                Console.WriteLine("qual sua idade");
                idade = int.Parse(Console.ReadLine());
                idadeSoma += idade;
            }
            Console.WriteLine("");
            Console.WriteLine("Média de idade dos Voluntários: "+ idadeSoma / qtPesquisa);
            */

            //Exercicio 6
            /* Console.WriteLine("Digite um número");
            var numeroInteiro = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numeroInteiro && numeroInteiro > 0; i--)
            {
                Console.WriteLine(numeroInteiro * 2);
                numeroInteiro--;
            }*/

            Console.ReadKey();
        }
    }
}
