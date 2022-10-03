// See https://aka.ms/new-console-template for more information

double salarioBruto;
double salarioLiquido;
double valorHorasNormais = 10.00;
double valorHorasExtras = 15.00;
double valorDesconto;

Console.Write("Entre com suas horas trabalhadas: ");
double horasNormais = double.Parse(Console.ReadLine());
Console.Write("Entre com suas horas extras: ");
double horasExtras = double.Parse(Console.ReadLine());

horasNormais = horasNormais * valorHorasNormais;
horasExtras = horasExtras * valorHorasExtras;

salarioBruto = horasNormais + horasExtras;
valorDesconto = salarioBruto * 10 / 100;
salarioLiquido = salarioBruto - valorDesconto;

Console.WriteLine("O valor a receber de horas normais é R$ " + horasNormais.ToString("F2"));
Console.WriteLine("O valor a receber de horas extras é R$ " + horasExtras.ToString("F2"));
Console.WriteLine("O salário bruto é R$ " + salarioBruto.ToString("F2"));
Console.WriteLine("O salário líquido com desconto é R$ " + salarioLiquido.ToString("F2"));
