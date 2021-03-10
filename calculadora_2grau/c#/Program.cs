using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
        double n1, n2, n3, x1,x2,delta;

            //Entrada
            Console.WriteLine("Calculadora de 2º Grau");

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("Os valores não podem ser igual a 0");
            }

            delta = Math.Pow(n2 , 2) - (4 * n1 * n3);

            if (delta < 0)
            {
                Console.WriteLine("Sua equação não tem raízes reais.");
            }

            else {
            x1 = (-n2 + Math.Sqrt(delta)) /(2*n1);
            x2 = (-n2 - Math.Sqrt(delta)) /(2*n1);

            Console.WriteLine($"O resultado de x1 é {x1} e de x2 é {x2}.");
            }

        }
    }
}
