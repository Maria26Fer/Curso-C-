using System;

namespace exercicio03While
{
    internal class exercicio03While
    {
        static void Main(string[] args)
        {
            //Exercício 03 da lista de estruturas de repetição;
            Console.WriteLine("Digite:");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            //Ler o valor e armazenar:
            int tipoDeCombustivel = int.Parse(Console.ReadLine());

            while (tipoDeCombustivel != 4)
            {
                if (tipoDeCombustivel == 1)
                {
                    alcool = alcool + 1;

                }
                else if (tipoDeCombustivel == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipoDeCombustivel == 3)
                {
                    diesel = diesel + 1;
                }

                tipoDeCombustivel = int.Parse (Console.ReadLine());

                Console.WriteLine("---------------------");
                Console.WriteLine("MUITO OBRIGADO!");
                Console.WriteLine("---------------------");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);

                Console.ReadLine();
            }
       
        }
    }
}
