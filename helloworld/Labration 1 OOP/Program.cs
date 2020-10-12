using System;
using System.Collections.Generic;

namespace Labration_1_OOP
{
    class Program
    {
        static Customer kund;
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen, är du ny kund här?");

            var answear = Console.ReadLine();
            if (answear=="ja")
            {
                kund = new Customer();
                kund._name = "Lucas";
            
            Console.WriteLine(kund._name);

            Console.WriteLine("Macka");
            Console.WriteLine("Läsk");
            Console.WriteLine("Cigg");
            Console.WriteLine("Lott");
               
            var val = Console.ReadLine();

            switch (val)
            }

                {

                    case "snus":
                        Console.WriteLine("En macka, något mer?");
                        
                    case "Läsk":
                        Console.WriteLine("En läsk, något mer?");

                    case "Cigg":
                        Console.WriteLine("En cigg, något mer?");

                    case "Lott":
                        Console.WriteLine("En lått, något mer?");
                }

     }
}
