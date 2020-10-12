
namespace OOPIntro
{
    class Person
    {

         string _name;


        public string name
        {
            get { return name; }
            set { name = value; }
        }


        int _age;

         Animal _pet;

        

        public Person(string name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

        public void ActivatePet()
        {
            _pet.Poop();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");
        }

        {
        public void Sleep()
        }
        {
             Console.WriteLine(_name + "is sleeping!")
        }
    }
}
