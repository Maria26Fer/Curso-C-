using System;
using System.Globalization;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");

            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.CalculoDaArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.CalculoDoPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.CalculoDaDiagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
