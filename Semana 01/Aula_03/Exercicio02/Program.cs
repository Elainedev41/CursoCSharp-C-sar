using System.Security.Cryptography.X509Certificates;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A = 2;
            int B = 3;
            int C = 5;
            int D = 9;
            int X = 0;

            if(!(D > 5))
            {
                X = (A + B) * D;
            }
            else
            {
                X = (A - B) / C;
                
            }

            Console.WriteLine(X);

            if ((A > 2) && (B < 7)) 
            {
                X = (A + 2) * (B - 2);
            }
            else
            {
                X = (A + B) / D * (C + D);
                
            }

            Console.WriteLine(X);

            if ((A == 2) || (B > 7))
            {
                X = (A + 2) * (B - 2);
            }
            else
            {
                X = (A + B) / D * (C + D);
                
            }

            Console.WriteLine(X);



            if ((A > 2) || !(B > 7))
            {
                X = A + B - 2;
            }
            else
            {
                X = A - B;
               
            }

            Console.WriteLine(X);
            
        }
    }
}