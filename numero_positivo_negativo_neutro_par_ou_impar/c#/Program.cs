using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
         int n; 

            //Entrada
            Console.WriteLine("Insira um Número Inteiro");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu número é Positivo, negativo ou neutro? Par ou ímpar? Pressione Qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Write("\n");

            //Processamento e saídas
            
            //Positivo, negativo, neutro.
            if (n > 0)
            { Console.Write("Seu número é positivo!\n");   
            }
            
            else if (n < 0) {
                Console.WriteLine("Seu número é negativo!\n");
            }
            else {
                Console.WriteLine("Seu número é neutro!\n");
            }

            //Par ou Impar
            if(n%2 == 0)
            {
                Console.WriteLine("O seu número é par!");
            }
            else
            {
                Console.WriteLine("O seu número é ímpar!");
            }

        }
    }
}
