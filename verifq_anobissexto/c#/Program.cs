using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
        //Variaveis
        int ano;

        //Entrada
        Console.WriteLine("Ano Bissexto ou Não?");
        Console.WriteLine("Insira um Ano!");
        ano = int.Parse(Console.ReadLine());

        //Processamento e saídas
        if (ano % 100 <=0 && ano % 400 == 0 || ano % 4 == 0) {
            Console.WriteLine ("Este ano é bissexto");
        }
        else {
            Console.WriteLine("Este ano não é bissexto");
        }
        }
    }
}
