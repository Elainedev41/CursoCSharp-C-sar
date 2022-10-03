namespace VerdadeiroFalse
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            int X = 1;
            int A = 3;
            int B = 5;
            int C = 8;
            int D = 7;

            bool a = !(X > 3);
            bool b = (X < 1) && !(B > D);
            bool c = !(D < 0) && (C > 5);
            bool d = !(X > 3) || (C < 7);                     
              
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}