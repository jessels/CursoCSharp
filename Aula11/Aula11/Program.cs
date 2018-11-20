using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaFuncionarios = new List<IFuncionarios>();            

            string continuarCadastro = "sim";

            while (continuarCadastro == "sim")
            {
                Console.WriteLine("Gostaria de cadastrar Encarregados (1), Gerentes (2) ou Supervisores (3)?");
                int opcaoCadastro = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoCadastro)
                {
                    case 1:
                        Console.WriteLine("|-- Cadastro de Encarregados --|\nQuantos Encarregados gostaria de cadastrar?");
                        int qtdEncarregados = int.Parse(Console.ReadLine());
                        Console.Clear();

                        for (int i = 0; i < qtdEncarregados; i++)
                        {
                            Encarregado encarregado = new Encarregado();                            

                            Console.WriteLine("|-- Encarregado " + (i + 1) + "--|\nDigite o nome:");
                            encarregado.Nome = Console.ReadLine();

                            Console.WriteLine("\nDigite a idade:");
                            encarregado.Idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nDigite o Salário atual:");
                            encarregado.Salario = encarregado.AumentoSalario(valorAtual: decimal.Parse(Console.ReadLine()));

                            Console.WriteLine("\nCadastro bem sucedido!");

                            listaFuncionarios.Add(encarregado);
                            Console.Clear();
                        }

                        break;

                    case 2:
                        Console.WriteLine("|-- Cadastro de Gerentes --|\nQuantos Gerentes gostaria de cadastrar?");
                        int qtdGerentes = int.Parse(Console.ReadLine());
                        Console.Clear();

                        for (int i = 0; i < qtdGerentes; i++)
                        {
                            Gerente gerente = new Gerente();

                            Console.WriteLine("|-- Gerente " + (i + 1) + "--|\nDigite o nome:");
                            gerente.Nome = Console.ReadLine();

                            Console.WriteLine("\nDigite a idade:");
                            gerente.Idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nDigite o Salário atual:");
                            gerente.Salario = gerente.AumentoSalario(valorAtual: int.Parse(Console.ReadLine()));
                            
                            Console.WriteLine("\nCadastro bem sucedido!");

                            listaFuncionarios.Add(gerente);
                            Console.Clear();
                        }

                        break;

                    case 3:
                        Console.WriteLine("|-- Cadastro de Supervisores --|\nQuantos Supervisores gostaria de cadastrar?");
                        int qtdSupervisores = int.Parse(Console.ReadLine());
                        Console.Clear();

                        for (int i = 0; i < qtdSupervisores; i++)
                        {
                            Supervisor supervisor = new Supervisor();

                            Console.WriteLine("|-- Supervisor " + (i + 1) + "--|\nDigite o nome:");
                            supervisor.Nome = Console.ReadLine();

                            Console.WriteLine("\nDigite a idade:");
                            supervisor.Idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nDigite o Salário atual:");
                            supervisor.Salario = supervisor.AumentoSalario(decimal.Parse(Console.ReadLine()));

                            Console.WriteLine("\nCadastro bem sucedido!");

                            listaFuncionarios.Add(supervisor);
                            Console.Clear();
                        }

                        break;

                    default:
                        break;
                }

                Console.WriteLine("Gostaria de efetuar mais algum cadastro?");
                continuarCadastro = Console.ReadLine();
                Console.Clear();               
            }


            foreach (var item in listaFuncionarios)
            {   
                if (item.GetType().BaseType == typeof(Funcionario))
                {
                    Funcionario e1 = (Funcionario)item;
                    Console.WriteLine("\nNome : " + e1.Nome);
                    Console.WriteLine("Idade: " + e1.Idade);
                    Console.WriteLine("Salário: " + e1.Salario);
                }
            }
            
            Console.ReadKey();
        }
    } 
}
