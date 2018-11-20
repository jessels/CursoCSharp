using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    public abstract class  ClasseAbstrata
    {

        public int Numero { get; set; }
        public string Nome { get; set; }


        public abstract void Calculo();

        public abstract string ObterNome();
    }
}
