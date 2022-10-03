namespace Exercicio03_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0; // variável para auxiliar a troca de valores.

            Console.Write("Entre com o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            if (num1 >= num3)
            {
                aux = num1;
                num1 = num3;
                num3 = aux;
            }

            if (num2 >= num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine("Valores Ordenados: " + num1 + ", " + num2 + ", " + num3);

        }
    }
}