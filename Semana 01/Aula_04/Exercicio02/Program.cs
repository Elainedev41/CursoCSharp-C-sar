using System.Collections.Generic;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numero = new HashSet<int>() {25, 30, 40, 25, 80, 40, 50, 80};
            Console.WriteLine("Elementos de número: ");

            foreach(var value in numero)
            {
                Console.WriteLine(value);
            }

        }
    }
}