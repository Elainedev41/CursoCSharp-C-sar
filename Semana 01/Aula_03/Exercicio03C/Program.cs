using System;
using System.Security.Cryptography.X509Certificates;

int maior = 0;
int menor = 0;
int numero = 0;

Console.Write("Entre com o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Entre com o segundo número: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Entre com o terceiro número: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Entre com o quarto número: ");
int num4 = int.Parse(Console.ReadLine());
Console.Write("Entre com o quinto número: ");
int num5 = int.Parse(Console.ReadLine());

for (int i = 0; i < numero ; i++)
{
    int[] num = new int[5];
    if (numero > maior)
    {
        maior = numero;
    }     
}

Console.WriteLine("O maior valor é: " + maior);


for (int i = 0; i < 5; i++)
{
    int[] num = new int[5];
    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine("O menor valor é: " + menor);

