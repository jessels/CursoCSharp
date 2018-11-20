using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula9
{
    class PessoaJuridica:Pessoa
    {
        public string InscricaoEstadual { get; set; }
        public string CNPJ { get; set; }
        

       public PessoaJuridica()
        {

        }
        public void AdicionaPessoaJuridica()
        {
            Console.WriteLine("Digite o Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a Cidade: ");
            Cidade = Console.ReadLine();
            Console.WriteLine("Digite o Bairro: ");
            Bairro = Console.ReadLine();
            Console.WriteLine("Digite o Estado: ");
            Estado = Console.ReadLine();
            Console.WriteLine("Digite o Pais: ");
            Pais = Console.ReadLine();
            Console.WriteLine("Digite o Inscrição Estadual: ");
            InscricaoEstadual = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ: ");
            CNPJ = Console.ReadLine();
        }
    }
}
