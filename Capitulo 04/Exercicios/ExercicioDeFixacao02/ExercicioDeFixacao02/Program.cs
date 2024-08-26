using System;
using System.Globalization;

namespace ExercicioDeFixacao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação de Dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
