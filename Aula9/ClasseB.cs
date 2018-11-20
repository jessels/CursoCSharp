using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class ClasseB:ClasseA
    {
        public int b { get; set; }

        public ClasseB()
        {
            Console.WriteLine("Contrutor da classe B");
        }
        public void MetodoClasseB()
        {
            Console.WriteLine("Metodo da classe B");
        }
    }
}
