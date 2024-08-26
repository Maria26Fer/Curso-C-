using System;
using System.Globalization;

namespace Curso
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculoDaArea() {
            return Largura * Altura;
        }
        public double CalculoDoPerimetro() {
            return 2 * (Largura + Altura);
        }

        public double CalculoDaDiagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
