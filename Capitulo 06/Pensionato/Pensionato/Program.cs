using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugado? ");
            int n = int.Parse(Console.ReadLine());

            //enquanto i for menor do que n "que é a quantidade de quartos alugados"
            // irá adicionar mais um;
            for (int i = 1; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++) { 
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ":" + vetor[i]);
                }
              
            }
            
        }
    }
}
