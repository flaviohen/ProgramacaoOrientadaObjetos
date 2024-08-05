using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    public class Pagamento
    {
        public Pagamento() { }

        public Pagamento(int identificacao, string tipoPagamento) {
            this.Identificacao = identificacao;
            this.tipoPagamento = tipoPagamento;
        }
       public int Identificacao { get; set; }
       public string tipoPagamento { get; set; }
    }
}
