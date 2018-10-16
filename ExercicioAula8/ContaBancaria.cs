using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula8
{
    class ContaBancaria
    {
        public Pessoa pessoa { get; set; }
        public List<Transacao> Transacaos{ get; set; }

        public ContaBancaria()
        {
            Transacaos = Transacaos;
        }
        
        public decimal GetSaldo()
        {
            decimal total = 0;

            foreach (var transacao in Transacaos)
            {
                if (transacao.Tipo == 1)
                {
                    total += transacao.Deposito;
                }
                else
                {
                    total -= transacao.Saque;
                }
                
            }return total;
        }
        public List<Transacao> TransacaoLista
        {
            get { return Transacaos; }

        }
       
     
       
    }
}
