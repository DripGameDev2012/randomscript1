using System;

namespace ConsoleApp1
{
	class Mailbox
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Tip: Try saying \"Do I have mail?\" ");
			bool mail;
			var what = Console.ReadLine();
			if (what == "Do I have mail?")
			{
				Random random = new Random();
				int integer = random.Next(0, 2);
				Console.WriteLine(integer);
				if (integer == 1)
				{
					mail = true;
					if (mail == true)
					{
						Mailbox1("is");
						Console.WriteLine("I'd recommend to now say \"How much mail is there?\" ");
						var what1 = Console.ReadLine();
						if

					}
				}
				else
				{
					mail = false;
					if (mail == false)
					{
						Mailbox1("is no");

					}
				}
			}
            else
            {
				Console.WriteLine("Sorry, but that wasn't typed correctly.");
            }
		}
		public static void Mailbox1(string ismail)
		{
			Console.WriteLine("There {0} mail", ismail);

		}
		public void Mailbox2(int howmuch)
        {
			Console.WriteLine("There is {0} pieces of mail", howmuch);
        }
	}
}