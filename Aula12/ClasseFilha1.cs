using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class ClasseFilha1 : ClasseAbstrata

    {
        public override void Calculo()
        {
            var numero = 1 * 500;
        }

        public override string ObterNome()
        {
            return "Classe filha 1";
        }
    }
}
