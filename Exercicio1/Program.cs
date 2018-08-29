using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio 1

            /* Console.WriteLine("Digite seu nome: ");
             var nome = Console.ReadLine();
             Console.WriteLine("Digite o ano de nascimento: ");
             var anoNascimento = int.Parse(Console.ReadLine());
             var ano = 2018;
             var idade = 0;


             idade = ano - anoNascimento;

             Console.WriteLine("Nome: "+ nome + " Idade é: " + idade);

             Console.ReadKey();*/

            //Exercicio 2

            /* Console.WriteLine("Digite seu nome: ");
             var nome = Console.ReadLine();

             Console.WriteLine("Digite seu salario: ");
             var salario = decimal.Parse(Console.ReadLine());

             Console.WriteLine("Digite seu percentual de aumento: ");
             var percentualAumento = decimal.Parse(Console.ReadLine());


             Console.WriteLine(nome + " seu novo salario é: " + ((salario * percentualAumento) / 100 + salario));

             Console.ReadKey();*/
            //Exemplo
            /*  Console.WriteLine("Qual sua idade? ");
              var idade = short.Parse(Console.ReadLine());

              if (idade == 18)
              {
                  Console.WriteLine("Idade igual a 18");
              }
              else
              {
                  Console.WriteLine("Idade não é igual a 18");

              }*/

            /*
            Console.WriteLine("Qual sua idade? ");
            var idade = short.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de pessoas");
            var pessoas = int.Parse(Console.ReadLine());

            if(idade >= 18 || pessoas > 1)
            {
                Console.WriteLine("Pode entrar na balada");
            }
            else
            {
                Console.WriteLine("Não Pode entrar na balada");
                 if(pessoas > 1)
                 {
                     Console.WriteLine("Pode entrar na balada");
                 }
                 else
                 {
                     Console.WriteLine("Não Pode entrar na balada");
                 }*/

            Console.WriteLine("Qual seu salario: ");
            var salario = decimal.Parse(Console.ReadLine());
            
            
            if (salario <= 1903.98M)
            {
                Console.WriteLine("sem dedução de imposto de renda");
            }
            
            if(salario >= 1903.99M && salario <= 2826.65M)
            {
                Console.WriteLine("Aliquota 7.5%, Valor do imposto é de " + (salario * 7.5M)/100);
            }
            if(salario >= 2826.66M && salario <= 3751.05M)
            {
                Console.WriteLine("Aliquota 15% Valor do imposto é de " + (salario * 15M) / 100);
            }
            if(salario >= 3751.06M && salario <= 4664.68M)
            {
                Console.WriteLine("Aliquota 22.5% Valor do imposto é de " + (salario * 22.5M) / 100);
            }
            if(salario > 4664.68M)
            {
                Console.WriteLine("Aliquota 27.5% Valor do imposto é de " + (salario * 27.5M) / 100);
            }
            Console.ReadKey();

            }
        

            










        
    }
}
