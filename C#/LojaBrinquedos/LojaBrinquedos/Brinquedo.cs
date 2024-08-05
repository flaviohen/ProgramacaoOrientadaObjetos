using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    //é dessa forma que herda uma classe da outra
    internal class Brinquedo : Produto
    {
        //é dessa forma que herda uma classe da outra
        public void Brincar(int codigoProduto)
        {

            switch (codigoProduto)
            {
                case 1:
                    Console.WriteLine("O Produto Pião: " + "Se enrola o barbante no pião e depois joga e puxa o barbante fazendo pião rodar no chão");
                    break;
                case 2:
                    Console.WriteLine("O Produto Bolinha de gude: Se coloca a bolinha entre dedo indicado e polegar forçando com o polegar a jogada da bolinha");
                    break;
                case 3:
                    Console.WriteLine("O Produto Bola de Tenis: Se uma taco de madeira para bater na bola e joga-la para longe");
                    break;
                case 4:
                    Console.WriteLine("O Produto castanha de caju de madeira: se joga a fim de acertar o buraco");
                    break;
            }
        }

        public string Brincar(double codigoProduto)
        {
            string retorno = "";
            switch (codigoProduto)
            {
                case 1:
                    retorno = "O Produto Pião: " + "Se enrola o barbante no pião e depois joga e puxa o barbante fazendo pião rodar no chão";
                    break;
                case 2:
                    retorno = "O Produto Bolinha de gude: Se coloca a bolinha entre dedo indicado e polegar forçando com o polegar a jogada da bolinha";
                    break;
                case 3:
                    retorno = "O Produto Bola de Tenis: Se uma taco de madeira para bater na bola e joga-la para longe";
                    break;
                case 4:
                    retorno = "O Produto castanha de caju de madeira: se joga a fim de acertar o buraco";
                    break;
            }
            return retorno;
        }
        public void Brincar(Brinquedo brinquedo)
        {
            Console.WriteLine("O Brinquedo e: " + brinquedo.NomeProduto + "-" + brinquedo.CaracteristicasProduto + "-" + Brincar((double)brinquedo.Identificacao));
        }
    }
}

