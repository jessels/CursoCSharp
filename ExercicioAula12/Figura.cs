using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula12
{
    public abstract class Figura
    {
        public string Descricao { get; set; }
        public decimal Lado{ get; set; }
        public decimal Perimetro { get; set; }
        public decimal Area { get; set; }

        public abstract decimal CalculoPerimetro();

        public abstract decimal CalculoArea();

    }
}
