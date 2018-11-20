using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula12
{
    class Triangulo : Figura
    {
        public int qtLadosTriangulo { get; set; }

        public override decimal CalculoArea()
        {
            Area = (Lado * Lado) / 2;

            return Area;
        }

        public override decimal CalculoPerimetro()
        {
            Perimetro = Lado * 3;

            return Perimetro;
        }
    }
}
