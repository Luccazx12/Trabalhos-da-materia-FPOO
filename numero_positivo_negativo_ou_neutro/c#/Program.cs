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
            Console.WriteLine("Insira um número Inteiro. Ele é Positivo, negativo ou neutro?");
            n = int.Parse(Console.ReadLine());

            //Processamento e saídas
            if (n > 0)
            { Console.Write("Esse número é positivo");   
            }
            
            else if (n < 0) {
                Console.WriteLine("Esse número é negativo");
            }
            else {
                Console.WriteLine("Esse número é neutro");
            }


            
        }
    }
}
