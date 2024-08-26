using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{produto1}, cujo preço é de ${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é de ${preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine($"Arredondando (três casas descimais): " + medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
