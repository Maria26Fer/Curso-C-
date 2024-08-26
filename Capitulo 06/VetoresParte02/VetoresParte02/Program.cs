using System;
using System.Globalization;

namespace VetoresParte02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//inicialmente vai pedir para informar a qtd dos produtos

            Produtos[] vect = new Produtos[n]; //iniciará valendo a quantidade informada

            //Esse for vai percorrer o Array e ir adicionando os valores na memoria
            for (int i = 0; i < n; i++) { 
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produtos { Name = name, Price = price };
            }
            double sum = 0.0;
            //Já esse for vai percorrer o Array armazenando os preços
            for (int i = 0; i < n; i++) { 
                sum += vect[i].Price;
            }
            double media = sum / n; //Essa formula vai realizar a soma pegando os valores do produtos
            Console.WriteLine("Media dos Preços: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
