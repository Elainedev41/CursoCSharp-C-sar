namespace Exercicio03_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resultado;

            Console.Write("Entre com a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double soma = nota1 + nota2 + nota3 + nota4;
            double media = soma / 4;

            if (media >= 5)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("Você foi " + resultado + ".Sua média foi: " + media);

        }
    }
}