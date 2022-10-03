namespace Exercicio03E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conceito = "";

            Console.Write("Entre com a nota (entre 0 a 10): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 9 && nota <=10)
            {
                conceito = "A";
            }
            else if(nota >= 7  && nota < 9)
            {
                conceito = "B";
            }
            else if(nota >=5 && nota < 7)
            {
                conceito = "C";
            }
            else if(nota >= 2 && nota < 5)
            {
                conceito = "D";
            }
            else if(nota >= 0 && nota < 2)
            {
                conceito = "E";
            }
            

            Console.WriteLine("Seu conceito é :  " + conceito);
        }
    }
}