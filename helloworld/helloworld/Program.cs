using System;

namespace helloworld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Vad heter du?:");
			string Lucas = Console.ReadLine();
            Console.WriteLine("Username is: " + Lucas);

			Console.WriteLine("Hur gammal är du:");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your age is: " + age);
		
			bool alive = true;
            if (alive == true)
            {
				Console.WriteLine("lever");
			}
            else
            {
				Console.WriteLine("död");
			}
		
		}
	}
}
