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
		
			if (30 > 10 )
			{
				Console.WriteLine("30 is greater than 10");
            }

			int ålder = 17;
			if (ålder < 18)
            {
				Console.WriteLine("Tyvärr går inte");
            }
		    else if (ålder > 18)
            {
				Console.WriteLine("62 kronor tack");
            }
		    else
            {
				Console.WriteLine("skit på dig");
            }

            for (int i = 0; i <= 10; i = i + 2)
            {
				Console.WriteLine(i);
            }

			int y = 0;
			while (y < 15)
            {

				Console.WriteLine(y);
				y++;

            }

			int person = 2;
			switch (person)
            {

				case 1:
					Console.WriteLine("Kalle");
					break;
				case 2:
					Console.WriteLine("Andre");
					break;
				case 3:
					Console.WriteLine("Malte");
					break;
			}

		}
	}
}
