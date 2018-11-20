using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Supervisor: Funcionario, IFuncionarios
    {

        public decimal AumentoSalario(decimal valorAtual)
        {
            Salario = valorAtual;
            return valorAtual * 1.05M;
        }
    }
}
