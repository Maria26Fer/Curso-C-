using System;
using System.Globalization;
namespace ExerciciosFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func = new Funcionarios();

            Console.WriteLine("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

            Console.ReadLine();
        }
    }
}
