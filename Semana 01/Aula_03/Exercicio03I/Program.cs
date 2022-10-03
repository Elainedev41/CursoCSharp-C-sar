using System.ComponentModel.Design;

namespace Exercicio03I
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            Console.Write("Entre com um número: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial;

            fatorial = numero;

            for (int i = 1; i < numero; i++)
            {
                fatorial *= i;                 
            }

            Console.WriteLine("Fatorial de " + numero + " é: " + fatorial);
        }
    }
}