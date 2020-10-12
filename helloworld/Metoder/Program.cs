using System;

namespace Metoder
{
    class Program 
    {
        static int adera(int[] talen)
        {
            int sum = 0;
           
            foreach (int tal in talen)
            {
                sum += tal;
            }

            return sum;
        }
        
        static void rev(string[] orden)
        {

            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(orden[i]);
            }
        }
        static void Main(string[] args)
        {

            int[] bajs = { 1, 2, 3 };
            Console.WriteLine(adera(bajs));


            string[] noobs = { "Kalle", "Kallle", "Kalllle", "Kallllle" };
            rev(noobs);
            
       
        }

    }
        
 }
 

