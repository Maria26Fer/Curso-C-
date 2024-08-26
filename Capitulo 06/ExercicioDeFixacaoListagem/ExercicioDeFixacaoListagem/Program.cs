using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixacaoListagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            //Enquanto i for menor ou igual a um, add mais um
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionarios #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, name, salario));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            int pesquisarId = int.Parse(Console.ReadLine());

            Funcionarios emp = list.Find(x => x.Id == pesquisarId);
            if (emp != null) {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionarios objeto in list)
            {
                Console.Write(objeto);
            }
            Console.ReadLine();
        }
    }
}
