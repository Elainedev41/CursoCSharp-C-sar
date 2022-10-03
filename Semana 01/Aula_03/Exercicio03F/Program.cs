namespace Exercicio03F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String faixa;

            Console.Write("Entre com sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double indice = peso / (altura * altura);

            if (indice <= 18.5)
            {
                faixa = "abaixo do peso";
            }
            else if (indice > 18.5 && indice <= 25)
            {
                faixa = "peso normal";
            }
            else if (indice > 25 && indice <= 30)
            {
                faixa = "peso acima do normal";
            }
            else
            {
                faixa = "peso excessivo";
            }

            Console.WriteLine("Seu indice corporal é " + indice + " sua faixa de peso é " + faixa);
        }
    }
    
}