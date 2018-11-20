using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {

            var primeira = new PrimeiraClasseInterface();

            primeira.Metodo1();
            primeira.Metodo2();
            primeira.Metodo3();
            primeira.Metodo4();


            var segunda = new SegundaClasseComInterface();

            segunda.Metodo1();
            segunda.Metodo2();
            segunda.Metodo3();
            segunda.Metodo4();


            Console.ReadKey();
        }
    }
}
