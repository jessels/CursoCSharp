using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente
            {
                Nome = "Jesse",
                Salario = 999,
                Cpf = "0000000000",
                Endereco = "rua de tal",
                Idade = 23
            };

            var cliente2 = new Cliente
            {
                Nome = "josias",
                Salario = 999,
                Cpf = "0000000000",
                Endereco = "rua de tal",
                Idade = 23
            };
            //Console.WriteLine(cliente.Nome);
            //Console.WriteLine(cliente2.Nome);

            var clientes = new Cliente[100];

            clientes[0] = cliente;
            clientes[1] = cliente2;


            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine(clientes[i].Nome);

            }


            Console.ReadLine();
        }
    }
}
