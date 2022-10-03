namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O exemplo de código a seguir demonstra vários métodos da Queue<T> classe genérica. O exemplo de
            // código cria uma fila de cadeias de caracteres com capacidade padrão e usa o Enqueue método para
            // enfileirar cinco cadeias de caracteres. Os elementos da fila são enumerados, o que não altera o
            // estado da fila. O Dequeue método é usado para desativar a primeira cadeia de caracteres.
            // O Peek método é usado para examinar o próximo item na fila e, em seguida, o Dequeue método é usado
            // para desempedi-lo.
            Queue<string> atendimento = new Queue<string>();
            string nome;
            int i = 1;
            int n = 1;

            for (; i <= 10; i++)
            {
                Console.Write("Digite seu nome para atendimento: ");
                nome = Console.ReadLine();
                Console.WriteLine("Sua senha é: {0}\n", i);
                atendimento.Enqueue(nome);
            }
            foreach (string lista in atendimento)
            {
                // É possivel colocar um sinal após o vetor que deseja e uma função de contagem com ++, para
                // simular uma lista de posição.
                Console.WriteLine("Ordem de chamada {0}º {1}", n++, lista);               
            }

            Console.WriteLine();
            Console.WriteLine("Saiu da fila: " + atendimento.Dequeue());
        }
    }
}