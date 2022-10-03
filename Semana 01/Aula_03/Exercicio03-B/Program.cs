namespace Exercicio03_B
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

            if (media >= 7)
            {
                resultado = "Aprovado";
                Console.WriteLine("Você foi " + resultado + ".Sua média é " + media);
            }
            else if (media < 7)
            {
                Console.WriteLine();
                Console.Write("Entre com a nota do exame: ");
                double notaExame = double.Parse(Console.ReadLine());

                double mediaExame = (media + notaExame) / 2;

                if (mediaExame >= 5)
                {
                    resultado = "Aprovado no exame";
                }
                else
                {
                    resultado = "Reprovado";
                }

                Console.WriteLine("Você foi " + resultado + ".Sua média é " + mediaExame);

            }
        }
    }
}