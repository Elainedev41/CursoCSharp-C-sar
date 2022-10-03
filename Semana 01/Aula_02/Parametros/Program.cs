// See https://aka.ms/new-console-template for more information

float[] numeros = {6, 8, 9 };

Console.WriteLine("Média: " + CalcularMedia(numeros).ToString("F2"));

static float CalcularMedia(float[] n)
{
    float media = 0;
    for(int i = 0; i < n.Length; i++)
        media += n[i];
    media /= n.Length;

    return media;
}
