using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    public class Prateleira
    {
      public Prateleira() { }

     public Prateleira(int codigoProduto, int quantidadeProduto, decimal precoProduto) 
     {
            this.codigoProduto = codigoProduto;
            this.quantidadeProduto = quantidadeProduto;
            this.precoProduto = precoProduto;
     }
      public int codigoProduto { get; set; }
      public int quantidadeProduto { get; set; }
      public decimal precoProduto { get; set; }
    }
}
