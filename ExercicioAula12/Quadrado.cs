using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula12
{
    class Quadrado : Figura
    {
        public int qtLados { get; set; }

        public override decimal CalculoArea()
        {
            Area = Lado * Lado;

            return Area;
        }

        public override decimal CalculoPerimetro()
        {
            Perimetro = Lado * 4;

            return Perimetro;
        }
    }
}
