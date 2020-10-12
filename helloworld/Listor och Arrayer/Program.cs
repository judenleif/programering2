using System;

namespace Listor_och_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] noobs = { "Kalle", "Kallle", "Kalllle", "Kallllle" };

            for (int i = 3; i >= 0 ; i--)
            {
                Console.WriteLine(noobs[i]);
            }
        
        }
    }
}
