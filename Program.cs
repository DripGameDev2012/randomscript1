using System;

namespace ConsoleApp1
{
	class Mailbox
	{
		public static void Main()
		{
			Console.WriteLine("Tip: Try saying \"Do I have mail?\" ");
			bool mail;
			var what = Console.ReadLine();
			if (what == "Do I have mail?")
			{
				Random random = new Random();
				int integer = random.Next(0, 2);
				if (integer == 1)
				{
					mail = true;
					if (mail == true)
					{
						Mailbox1("is");
						Console.WriteLine("Tip: Try saying \"How much mail is there?\" ");
						var what1 = Console.ReadLine();
						if (what1 == "How much mail is there?")
                        {
							Random randomNumberGenerator = new Random();
							int integer1 = random.Next(1, 1000);
							
							Mailbox2(integer1);

							Console.WriteLine("Tip: Try saying \"Read me an email.\"");
							var bruh = Console.ReadLine();
							if (bruh == "Read me an email.")
                            {
								
								for(int i = 0; i < 51; i++)
                                {
									Console.WriteLine("ERROR 101. NO MAIL MADE.");
                                }
								
                            }
                            else
                            {
								Console.WriteLine("Sorry, but that wasn't typed correctly.");
								Main();
                            }
						}
                        else
                        {
							Console.WriteLine("Sorry, but that wasn't typed correctly.");
							Main();
                        }
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
				Main();
            }
		}
		public static void Mailbox1(string ismail)
		{
			Console.WriteLine("There {0} mail", ismail);

		}
		public static void Mailbox2(int howmuch)
        {
			Console.WriteLine("You have {0} mail", howmuch);
        }
		
	}
}