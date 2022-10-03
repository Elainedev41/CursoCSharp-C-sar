// See https://aka.ms/new-console-template for more information 

Console.Write("Entre com sua em idade em anos: ");
int idadeAnos = int.Parse(Console.ReadLine());
Console.Write("Entre com seus meses: ");
int meses = int.Parse(Console.ReadLine());
Console.Write("Entre com os dias: ");
int dias = int.Parse(Console.ReadLine());

int total;

idadeAnos = idadeAnos * 365;
meses = (meses -1) * 30;

total = idadeAnos + meses + dias;


Console.WriteLine("Idade em anos = " + idadeAnos);
Console.WriteLine("Meses = " + meses);
Console.WriteLine("dias = " + dias);
Console.WriteLine("O total em dias é " + total);

