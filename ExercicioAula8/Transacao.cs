using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula8
{
    class Transacao
    {
        public DateTime Data { get; set; }
        public int Tipo { get; set; } //1 - deposito  2 - saque
        public decimal Deposito { get; set; }
        public decimal Saque { get; set; }

        public Transacao()
        {
            Data = DateTime.Now;
        }

    }
}
