using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            var classeFilha1 = new ClasseFilha1();
            classeFilha1.Nome = "Jessé";
            classeFilha1.Numero = 500;


            var lista = new List<ClasseAbstrata>();

            lista.Add(classeFilha1);

            foreach (var item in lista)
            {
                Console.WriteLine(item.ObterNome());
            }

            Console.ReadKey();
        }
    }
}
