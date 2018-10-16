using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem Vindo ao Banco!!");

            Console.Write("Digite seu Nome para criar a conta: ");
            var pessoa = new Pessoa {Nome = Console.ReadLine() };
            Console.Clear();

            Console.WriteLine("Olá! " + pessoa.Nome );
            Console.WriteLine("Para acessar nosso Menu digite: \n 1 - Menu \n 0 - Sair");
            var menu = Console.ReadLine();
            var transacoes = new List<Transacao>();
            var conta = new ContaBancaria { };
            while (menu == "1")
            {

            var tipo = 0;

                
            Console.WriteLine("Informe o tipo de operação que deseja realizar, " +
                "\n 1 - Deposito \n 2 - Saque \n 3 - consultar saldo \n 4 - Extrato Bancario");
            tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Informe o valor do deposito ");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());

                        var transacaoDeposito = new Transacao { Data = DateTime.Now, Tipo = tipo, Deposito = valorDeposito };
                        transacoes.Add(transacaoDeposito);

                        conta = new ContaBancaria { pessoa = pessoa, Transacaos = transacoes};

                        Console.WriteLine("--------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor do Saque");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());

                        var transacaoSaque = new Transacao { Data = DateTime.Now, Tipo = tipo, Saque = valorSaque };
                        transacoes.Add(transacaoSaque);
                        conta = new ContaBancaria { pessoa = pessoa, Transacaos = transacoes };

                        Console.WriteLine("--------------------------------------");
                        break;
                    case 3:

                        
                        Console.WriteLine("Seu saldo é de: "+ conta.GetSaldo());
                        Console.WriteLine("--------------------------------------");
                        
                       
                        break;
                    case 4:

                        foreach (var dados in conta.TransacaoLista)
                        {
                            if (dados.Tipo == 1)
                            {
                                Console.WriteLine("Data: " + dados.Data);
                                Console.WriteLine("Tipo: " + dados.Tipo);
                                Console.WriteLine("Deposito: " + dados.Deposito);
                                Console.WriteLine("--------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Data: " + dados.Data);
                                Console.WriteLine("Tipo: " + dados.Tipo);
                                Console.WriteLine("Saque: " + dados.Saque);
                                Console.WriteLine("--------------------------------------");
                            }
                           
                        }
                        Console.WriteLine("--------------------------------------");

                        break;

                    default:
                        menu = "0";
                        break;
                        
                         
            }
                

            }
            

            Console.ReadKey();
        }
    }
}
