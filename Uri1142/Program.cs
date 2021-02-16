using System;

namespace Uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;

            a = 1;
            b = 2;
            c = 3;

            n = int.Parse(Console.ReadLine());

            for(int i=0; i<n;i++)
            {
                
                Console.WriteLine(a + " " + b + " " + c + " Pum");

                a += +4;
                b += +4;
                c += 4;
            }
        }
    }
}
