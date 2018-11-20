using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula9
{
    class PessoaFisica:Pessoa
    {
        public string CPF { get; set; }
        public string RG{ get; set; }

        public PessoaFisica()
        {

        }
        public void AdicionaPessoa()
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
            Console.WriteLine("Digite o CPF: ");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite o RG: ");
            RG = Console.ReadLine();
        }
        
    }
}
