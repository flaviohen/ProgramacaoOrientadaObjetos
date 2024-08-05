using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    public class Produto
    {
        //Em C# pode encapsular os atributos tambem dessa forma
        //Para ter um objeto com seus atributos sem valores, deve criar o construtor vazio

        public Produto() { }
        public Produto(int identificacao, int identificacaoUnica, string nomeProduto, string caracteristicasProduto) {
            this.Identificacao = identificacao;
            this.IdentificacaoUnica = identificacaoUnica;
            this.NomeProduto = nomeProduto;
            this.CaracteristicasProduto = caracteristicasProduto;
        }


        public int Identificacao { get; set; }
        public int IdentificacaoUnica { get; set; }
        public string NomeProduto { get; set; }
        public string CaracteristicasProduto { get; set; }

        /*public void SetIdentificacao(int identificacao) {
            this.Identificacao = identificacao;
        }

        public int GetIdentificacao() {
            return Identificacao;
        }

        public void SetIdentificacaoUnica(int identificacaoUnica) {
            this.IdentificacaoUnica = identificacaoUnica;
        }

        public int GetIdentificacaoUnica() {
            return this.Identificacao;
        }

        public void SetNomeProduto(string nomeProduto) {
            this.nomeProduto = nomeProduto;
        }
        public string GetNomeProduto() {
            return this.nomeProduto;
        }

        public void SetCaracteristicaProduto(string caracteristicaProduto) {
            this.caracteristicasProduto = caracteristicaProduto;
        }

        public string GetCaracteristicaProduto() {
            return this.caracteristicasProduto;
        }
        */
    }
}
