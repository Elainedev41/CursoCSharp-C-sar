namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int quantidadeLugares = 100;
            string[,] cinema = new string[quantidadeLugares * 2, 2];
            int contador = 0;
            int quantidadeRespostasOtimo = 0;
            float mediaIdadeRuim = 0;
            float porcentagemPessimo;
            int quantidadePessimos = 0;
            int quantidadeRuins = 0;
            float idadePessimo;
            int idade;
            string resposta;
            int maiorIdadePessimo = 0;

            while (contador <= quantidadeLugares)
            {
                Console.Write("Qual a sua idade: ");
                cinema[contador, 0] = Console.ReadLine();
                Console.Write("Sua opinião (O)Ótimo, (B)Bom, (R)Regular, U(Ruim) ou (P)Péssimo");
                cinema[contador, 1] = Console.ReadLine();
                contador++;
            }

            for( contador = 0; contador < quantidadeLugares; contador++)
            {
                idade = int.Parse(cinema[contador,0]);
                resposta = cinema[contador,1];
                if (resposta == "P" && idade > maiorIdadePessimo) 
                    maiorIdadePessimo = idade;
                if (resposta == "P")
                    quantidadePessimos++; 
                if(resposta == "U")
                {
                    mediaIdadeRuim += idade;
                    quantidadeRuins++;
                }
                mediaIdadeRuim += quantidadeRuins;
                if(resposta == "O")
                    quantidadeRespostasOtimo++;
            }

            mediaIdadeRuim /= (float) quantidadeLugares;
            porcentagemPessimo = (((float)quantidadePessimos / (float)quantidadeLugares) * 100);

            Console.WriteLine("Quantidade de respostas ótimas: " + quantidadeRespostasOtimo.ToString());
            Console.WriteLine("Média da idade de pessoas que responderam Ruim: " + mediaIdadeRuim.ToString("F2"));
            Console.WriteLine("Porcentagem de classificação Péssimas: " + porcentagemPessimo.ToString("F2") + "%");
            Console.WriteLine("Maior idade que respondeu péssimo: " + maiorIdadePessimo);
        } 
    }
}