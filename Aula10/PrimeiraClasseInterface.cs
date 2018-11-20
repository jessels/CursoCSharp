using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class PrimeiraClasseInterface : IPrimeiraInteface
    {
        public void Metodo1()
        {
            Console.WriteLine("Entrei no metodo 1");
        }

        public void Metodo2()
        {
            Console.WriteLine("Entrei no metodo 2");
        }

        public decimal Metodo3()
        {
            Console.WriteLine("Entrei no metodo 3");

            return 0;
        }

        public string Metodo4()
        {
            return Console.WriteLine("Entrei no metodo 1");
        }
    }
}
