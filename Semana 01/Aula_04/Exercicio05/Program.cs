namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> My_dict =new Dictionary<int, string>();

            My_dict.Add(1, "Thiago Rodrigues");
            My_dict.Add(2, "André Machado");
            My_dict.Add(3, "Fernando Silva");
            My_dict.Add(4, "Luiz Ricardo");
            My_dict.Add(5, "Andréia Morena");
            My_dict.Add(6, "Ana Rodrigues");
            My_dict.Add(7, "Eduarda Abreu");
            My_dict.Add(8, "Miguel Fernandes");
            My_dict.Add(9, "Ana Paula Oval");
            My_dict.Add(10, "Leandro Sodre");
            My_dict.Add(11, "Ana Pereira");
            My_dict.Add(12, "Carla Jesus");
            My_dict.Add(13, "Edna Batista");
            My_dict.Add(14, "Hugo Dias");
            My_dict.Add(15, "Hugo Machado");
            My_dict.Add(16, "Thiago Felix");
            My_dict.Add(17, "Renato Santana");
            My_dict.Add(18, "Yuri Martins");
            My_dict.Add(19, "Rafaella Dias");
            My_dict.Add(20, "Davi Silva");

            foreach (KeyValuePair<int, string> ele1 in My_dict)
            {
                Console.WriteLine("{0} : {1}", ele1.Key, ele1.Value);
            }

            Console.WriteLine("O aluno(a) nº 7 é : " + My_dict[7]);
            Console.WriteLine();
        }
    }
}