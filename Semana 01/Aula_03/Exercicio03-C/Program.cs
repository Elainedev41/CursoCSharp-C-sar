namespace Exercicio03_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int menor = int.MaxValue;
            int qtdNumeros = 5;
            int[] numeros = new int[qtdNumeros];
            
           Console.Write("Informe cinco números: ");
                       

            for(int i = 0; i < qtdNumeros; i++)
            {
                Console.Write((i + 1) + "º número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 5; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else if(numeros[i] > maior) 
                {
                    maior = numeros[i];
                }
            }

            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);
        }
    }
}