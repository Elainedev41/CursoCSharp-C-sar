namespace Exercicio03G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De qual valor será sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            int resultado;

            for(int i = 0; i <= 10; i++)
            {
                resultado = num * i;
                Console.WriteLine(num + " * " + i + " = " + resultado);
            }           
        }
    }
}