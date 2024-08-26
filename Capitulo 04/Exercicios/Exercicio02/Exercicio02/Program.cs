using System;
using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios primeiroFuncionario = new Funcionarios();
            Funcionarios segundoFuncionario = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: " );
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine() ;
            Console.WriteLine("Salário: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
