using System;

namespace Exercicio01
{
    internal class Exercicio01
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());//Lembrar de fazer a formatação com o Parse

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome:");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)//lembrar de referenciar o objeto
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa2.Nome);
            }

            Console.ReadLine();

        }
    }
}
