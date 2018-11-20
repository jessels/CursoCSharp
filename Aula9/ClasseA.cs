using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class ClasseA
    {
        public int a{ get; set; }

        public ClasseA()
        {
            Console.WriteLine("Construtor da classe A");
        }
        public void MetodoClasseA(string nome)
        {
            Console.WriteLine("sou o " + nome);
        }
    }
}
