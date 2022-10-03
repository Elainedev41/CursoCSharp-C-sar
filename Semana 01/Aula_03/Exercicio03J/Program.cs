namespace Exercicio03J
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um número: ");
            int num = int.Parse(Console.ReadLine());

            int cont = 1;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                Console.WriteLine("O número " + num + " é primo");
            }
            else
            {
                Console.WriteLine("O número " + num + " não é primo");
            }
        }
    }
}