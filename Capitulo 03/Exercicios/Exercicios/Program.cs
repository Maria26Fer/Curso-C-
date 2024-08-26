using System;
using System.Globalization;

namespace Exercicios
{
    internal class Exercicios
    {
        static void Main(string[] args)
        {
            /*Exercício N 1
             * Console.WriteLine("DIGITE OS VALORES:");

            Console.WriteLine("---------------------");

            double largura, comprimento, precoMetroQuadrado, area, preco;
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("---------------------");

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("---------------------");

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));*/

            /*Exercício N 2

            Console.WriteLine("Digite sua Nota:");
            double nota1, nota2, soma;

            Console.WriteLine("------------------");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------");
            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------");

            if(soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }*/

            /* Exercicío N 3
            * double a, b, c, delta, r1, r2;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular!");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }*/

            /*Exercício N 4*/
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            //Não sei a quantidades de vezes que será repitido, então eu usarei o while

            while (x != y)
            {
                if (x < y) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente");
                }
                    vet = Console.ReadLine().Split(' ');
                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                }

                Console.ReadLine();
            }
        }
    }
