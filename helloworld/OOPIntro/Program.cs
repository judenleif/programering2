using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pet = new Animal();
            pet._name = "bajskorv";
            pet._species = "korv";
            pet._color = "brun";

            Person lucas = new Person("Lucas", 18);

            
            lucas.Eat();
            lucas.Sleep();

            lucas.ActivatePet();


        }
    }
}
