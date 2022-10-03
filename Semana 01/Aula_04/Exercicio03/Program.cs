using System.Collections;
using System.Collections.Generic;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack sequencia = new Stack();
            char resultado = ' ';

            while (resultado != '-')
            {
                Console.Write("Entre com um caracter: ");
                Console.WriteLine("- Sair");
                resultado = char.Parse(Console.ReadLine());

                if (resultado == resultado)
                {
                   sequencia.Push(resultado);
                }
            }
            Console.Write("\nOrdem dos valores digitados:\n");

            foreach (var letras in sequencia)
            {
                Console.Write("{0}", letras);
            }

            Stack elemento = new Stack(sequencia.ToArray());

            Console.Write("\nOrdem inversa:\n");
            foreach (var numero in elemento)
            {
                Console.Write(numero);
            }

        }
    }
}
