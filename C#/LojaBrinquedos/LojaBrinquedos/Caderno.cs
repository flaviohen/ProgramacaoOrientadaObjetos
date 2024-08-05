using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    public class Caderno
    {
        public Caderno() { }

        public Caderno(int identificacao, int codigoProduto, int quantidadeVendida, decimal totalVenda, DateTime dataVenda, int tipoPagamento)
        {
            this.Identificacao = identificacao;
            this.codigoProduto = codigoProduto;
            this.quantidadeVendida = quantidadeVendida;
            this.totalVenda = totalVenda;
            this.DataVenda = dataVenda;
            this.tipoPagamento = tipoPagamento;
        }

        public int Identificacao { get; set; }
        public int codigoProduto { get; set; }
        public int quantidadeVendida { get; set; }
        public decimal totalVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public int tipoPagamento { get; set; }

        //Criando um metodo ou funcao
        public void RegistrarVenda(Caderno registro)
        {
            Console.WriteLine("Registro de Venda: " + registro.Identificacao + "-" + registro.codigoProduto + "-" + registro.quantidadeVendida + "-" + registro.totalVenda + "-" + registro.DataVenda + "-" + registro.tipoPagamento);
        }

        public void RegistrarVenda(int identificacao, int codigoProduto, int quantidadeVendida, decimal totalVenda, DateTime dataVenda, int tipoPagamento)
        {
            Console.WriteLine("Registro de Venda: " + identificacao + "-" + codigoProduto + "-" + quantidadeVendida + "-" + totalVenda + "-" + "-" + dataVenda + "-" + tipoPagamento);
        }
        public void RegistrarVenda(string registro)
        {
            Console.WriteLine(registro);
        }

        public void TestarProduto(int codigoProduto)
        {
            new Brinquedo().Brincar(codigoProduto);
        }
    }
}
