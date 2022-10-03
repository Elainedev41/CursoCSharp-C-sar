// See https://aka.ms/new-console-template for more information

double compra;

Console.Write("Entre com a quantidade de maçãs: "); 
int qtdMacas = int.Parse(Console.ReadLine());

if(qtdMacas < 12)
{
    compra = qtdMacas * 1.30;
}
else
{
    compra = qtdMacas * 1.00;}


Console.WriteLine("O custo total da compra foi de R$ " + compra);
