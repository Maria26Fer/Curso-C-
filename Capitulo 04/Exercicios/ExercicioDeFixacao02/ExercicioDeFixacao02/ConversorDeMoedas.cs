using System;
using System.Globalization;

namespace ExercicioDeFixacao02
{
    internal class ConversorDeMoedas
    {
        public static double Informe = 6.0;
        
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Informe / 100.0;
        }
    }
}
