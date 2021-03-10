using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
//Variaveis
int l1,l2,l3;

// Entrada
Console.WriteLine("Digite o número 1:");
l1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 2:");
l2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número 3:");
l3 = int.Parse(Console.ReadLine());

//Processamento e Saída
    if (l1 > (l2 + l3) || l2 > (l1 + l3) || l3 > (l1 + l2)) {
        Console.WriteLine("Não pode ser um triângulo");
    }
    else if (l1 == l2 && l1 == l3 && l2 == l3 ) {
        Console.WriteLine("Equilatero");
        }
    else if (l1 == l2 || l1 == l3 || l2 == l3) {
        Console.WriteLine("Isósceles");
        }
    else{
        Console.WriteLine("Escaleno");
        }
        }
    }
}
