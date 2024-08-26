using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    internal class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho } // Sempre se se referenciar a Cor, terá que ter um desses valores;

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            //funções
            /*GerarPreco(60);
            GerarPreco(90);
            GerarPreco(-100);

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);*/

            //Arrays
            /*string[] produtos = new string[5]
            {
                "Café",
                "leite",
                "Açucar",
                "doce",
                "uva",
            };

            //criando um array assim o c# ja entende a quantidade de elementos dentro dele
            int[] valores = {1, 2, 3, 4, 5}; 

            //alterando um valor já existente
            produtos[0] = "Café com açucar";
            Console.WriteLine(produtos[0]);*/

            //Switch
            /*string cor = "Verde";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Cor vermelho.");
                    break;
                case "azul":
                    Console.WriteLine("Cor azul.");
                    break;
                case "preto":
                    Console.WriteLine("Cor preto.");
                    break;
                default:
                    Console.WriteLine("Cor não encontrada.");
                    break;
            }*/

            //Enum
            /*Cor corFavorita = Cor.Azul;
            Cor corFavorita2 = Cor.Verde;

            Console.WriteLine((int)corFavorita); //processo de cast, converte um valor em outro;
            Console.WriteLine(corFavorita2);*/


            /*Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            Console.WriteLine(opcaoSelecionada);

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Crie algo.");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Delete agora!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Edite algo.");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }*/

            //Estrutura de repetição While e do While
            /*int contador = 0;
            while (contador < 10) //enquanto for verdade faça!
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o While!");
                //contador = contador + 1;
                //contador += 1;
                contador++;
            }

            do
            {
                Console.WriteLine("do While");
            } while (1000 < 10);

            Console.WriteLine("FIMM!!!");*/

            //Foreach -> serve para percorrer arrays
            /*string[] palavras = { "Maria", "Fernanda", "Guia do prog" };

            foreach (string palavra in palavras)//para cada palavra no array palavras  salve e repita o bloco de codigo

            { 
                Console.WriteLine(palavra); 
            }*/

            //For var que será iniciada, condição que será atendida e o incremento
            /*string[] palavras = { "Maria", "Fernanda", "Guia do prog" };

            for (int contador2 = palavras.Length - 1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }



            Console.WriteLine("FIM!");*/


            Console.ReadLine();
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Mensagem aleatoria!");
        }

        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor Final: " + valorFinal);
        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;

            return resultadoFinal;
        }
    }
}
