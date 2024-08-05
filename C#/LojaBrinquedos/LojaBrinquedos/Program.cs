using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LojaBrinquedos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Produto objetoProduto;
            Pagamento objetoPagamento;
            Prateleira objetoPrateleira;
            Caderno objetoCaderno;*/

            //Criando ou instanciando os objetos
            /*objetoProduto = new Produto();
            objetoPagamento = new Pagamento();
            objetoPrateleira = new Prateleira();
            objetoCaderno = new Caderno();*/

            //E isto são objetos
            //Agora separando os arquivos

            //Vamos criar os objetos para os arquivos separados

            Produto objetoProduto;
            Pagamento objetoPagamento;
            Prateleira objetoPrateleira;
            Caderno objetoCaderno;

            //Criando ou instanciando os objetos
            objetoProduto = new Produto(1,1,"Pião","Madeira");
            objetoPagamento = new Pagamento(1,"Dinheiro");
            objetoPrateleira = new Prateleira(1,10,1.50M);
            objetoCaderno = new Caderno(1,1,20,20*1.50M,DateTime.Now, 1);

            //Nos arquivos separados coloque public na frente
            //E isto são classes e objetos

            //Criando os atributos das classes

            //atributo não visivel
            //Isto é encapsula o atributo
            /*objetoProduto.Identificacao = 1;
            objetoProduto.IdentificacaoUnica = 1;
            objetoProduto.NomeProduto = "Pião";
            objetoProduto.CaracteristicasProduto = "Madeira";
            */
            //atribuindo valores diretamentamente 
            Console.WriteLine(objetoProduto.Identificacao + "-" + objetoProduto.IdentificacaoUnica + "-" + objetoProduto.NomeProduto + "-" + objetoProduto.CaracteristicasProduto);

            /*objetoPagamento.Identificacao = 1;
            objetoPagamento.tipoPagamento = "Dinheiro";
            */
            Console.WriteLine(objetoPagamento.Identificacao + "-" + objetoPagamento.tipoPagamento);

            /*objetoPrateleira.codigoProduto = 1;
            objetoPrateleira.quantidadeProduto = 2;
            objetoPrateleira.precoProduto = 10.10M;
            */
            Console.WriteLine(objetoPrateleira.codigoProduto + "-" + objetoPrateleira.quantidadeProduto + "-" + objetoPrateleira.precoProduto);

            /*objetoCaderno.Identificacao = 1;
            objetoCaderno.codigoProduto = 1;
            objetoCaderno.quantidadeVendida = 3;
            objetoCaderno.totalVenda = objetoCaderno.quantidadeVendida * objetoPrateleira.precoProduto;
            objetoCaderno.DataVenda = DateTime.Now;
            objetoCaderno.tipoPagamento = 1;
            */
            Console.WriteLine(objetoCaderno.Identificacao + "-" + objetoCaderno.codigoProduto + "-" + objetoCaderno.quantidadeVendida + "-" + objetoCaderno.DataVenda + "-" + objetoCaderno.totalVenda + "-" + objetoCaderno.tipoPagamento);

            //E assim adiciona atributos nas classes

            //Vamos encapsular os atributos da classe
            //atributos encapsulados

            //Criando o construtor da classe, existe por padrão um contrustor para toda classe
            //criado quando dar o new classe() este é o construtor padrão, o construtor serve para iniciar um objeto 
            //com seus atributos ja iniciados com valores;
            //Construtores criados

            //Vamos aprender metodos ou função com e sem parametros
            
            void Mensagem()
            {
                Console.WriteLine("Ola, Mundo!");
            }

            //Metodo com parametro
            void Mensagem2(string mensagem) {
                Console.WriteLine(mensagem);
            }

            //Chamando o metodo
            Mensagem();
            Mensagem2("Ola Mundo2!");

            //Isso são metodos
            //Vamos agora usar com orientação objeto usando objetos e classes
            objetoCaderno.RegistrarVenda(objetoCaderno);
            objetoCaderno.RegistrarVenda(objetoCaderno);

            //novo registro
            objetoCaderno.Identificacao = 2;
            objetoCaderno.codigoProduto = 2;
            objetoCaderno.quantidadeVendida = 3;
            objetoCaderno.totalVenda = objetoCaderno.quantidadeVendida * 4.0M;
            objetoCaderno.DataVenda = DateTime.Now;
            objetoCaderno.tipoPagamento = 1;

            objetoCaderno.RegistrarVenda(objetoCaderno);

            //E isto são metodos ou função com e sem parametros
            //Agora vamos aprender sobre sobrecarga de metodo ou função
            //sobrecarga de metodos são metodos com o mesmo nome com diferentes
            //quantidade de parametros e ou retorno diferente

            Metodo1();
            Metodo1("Mensagem");
            Console.WriteLine(Metodo1(1));
            Console.WriteLine(Metodo1("", 1.6f));

            //é possivel fazer do mesmo jeito nas classes e chamar os metodos com o objeto
            objetoCaderno.RegistrarVenda(objetoCaderno);
            objetoCaderno.RegistrarVenda(1, 1, 1, 1.5M, DateTime.Now, 1);
            objetoCaderno.RegistrarVenda("1-1-1-2.5-2024-08-04-1");

            //e isto são sobrecarga de metodo ou função
            //Vamos agora aprender sobre polimorfismo, vamos demonstrar como o produto que 
            //estamos trabalhando no caso brinquedo
            //temos aqui a especificação brinquedo, e os brinquedos podem ser pião, bola de gude, bola de tenis ou castanha de caju de madeira
            //e temos o metodo ou função brincar, porem cada brinquedo se brinca de forma diferente e dessa forma que 
            // que o poliformismo funciona vamos demonstrar na programação orientada a objetos
            Console.WriteLine("Antes de vender testar o produto");
            objetoCaderno.TestarProduto(1);
            objetoCaderno.TestarProduto(2);
            objetoCaderno.TestarProduto(3);
            objetoCaderno.TestarProduto(4);



            //e isto é o polimorfismo

            //Vamos aprender agora herança, em resumo é herança é uma classe que contem atributos padrão
            //para o tipo da classe, exemplo o temos a classe produto e temos a classe brinquedo com metodo brincar
            //os atributos do brinquedo são os que estão na classe produto, dessa forma vamos fazer a classe
            //brinquedo herdar esses atributos sem precisa colocar na classe digitando

            Brinquedo objetoBrinquedo = new Brinquedo();
            objetoBrinquedo.Identificacao = 1;
            objetoBrinquedo.IdentificacaoUnica = 1;
            objetoBrinquedo.NomeProduto = "Pião";
            objetoBrinquedo.CaracteristicasProduto = "Madeira";

            objetoBrinquedo.Brincar(objetoBrinquedo);
        }

        static void Metodo1() {
            Console.WriteLine("Metodo1");
        }

        static void Metodo1(string mensagem) {
            Console.WriteLine(mensagem);
        }

        static string Metodo1(int numero) {
            return "1" + numero;
        }

        static double Metodo1(string nome, float valor) {
            if (nome == "")
            {
                return 0.0;
            }
            else {
                return valor * 2;
            }
        }

    }

    
    //Duas forma de criar classes em C# no mesmo ou arquivo ou em 
    //arquivos separados, vou demonstrar as duas formas.

    //Classes 

    /*
    class Produto { 
    
    }

    class Pagamento { 
    
    }

    class Prateleira { 
    
    }

    class Caderno { 
    
    }
    */

}
