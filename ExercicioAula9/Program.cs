using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adicione Pessoas");
            var listaPessoaFisica = new List<PessoaFisica>();
            var listaPessoaJuridica = new List<PessoaJuridica>();

            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PessoaJuridica();

            Console.WriteLine("Informe a quantidade de Pessoas: ");
            int qtPessoa = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtPessoa; i++)
            {

            
            

            
                
                Console.WriteLine("1 - para pessoa fisica ou 2 - para pessoa Juridica");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        
                        pessoaFisica.AdicionaPessoa();
                        listaPessoaFisica.Add(pessoaFisica);



                        break;
                    case "2":
                        
                        pessoaJuridica.AdicionaPessoaJuridica();
                        listaPessoaJuridica.Add(pessoaJuridica);

                        break;
                    case "3":

                        break;

                    default:
                        break;
                }
            }
            Console.Clear();

            foreach (var lista in listaPessoaFisica)
            {
                Console.WriteLine("Pessoa Fisica");
                Console.WriteLine("Nome: " + pessoaFisica.Nome);
                Console.WriteLine("Cidade: " + pessoaFisica.Cidade);
                Console.WriteLine("Bairro: " + pessoaFisica.Bairro );
                Console.WriteLine("Estado: " + pessoaFisica.Endereco);
                Console.WriteLine("Pais:  " + pessoaFisica.Pais);
                Console.WriteLine("CPF: " + pessoaFisica.CPF);
                Console.WriteLine("RG: " + pessoaFisica.RG);
                
            }
            foreach (var listaJuridica in listaPessoaJuridica)
            {
                Console.WriteLine("Pessoa Juridica");
                Console.WriteLine("Nome: " + pessoaJuridica.Nome);
                Console.WriteLine("Cidade: " + pessoaJuridica.Cidade);
                Console.WriteLine("Bairro: " + pessoaJuridica.Bairro);
                Console.WriteLine("Estado: " + pessoaJuridica.Endereco);
                Console.WriteLine("Pais:  " + pessoaJuridica.Pais);
                Console.WriteLine("Inscrição Estadual: " + pessoaJuridica.InscricaoEstadual);
                Console.WriteLine("CNPJ: " + pessoaJuridica.CNPJ);
            }

            Console.ReadKey();      
            
        }
    }
}
