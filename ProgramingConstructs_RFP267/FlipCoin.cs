using System;
namespace ProgramingConstructs_RFP267
{
	public class FlipCoin
	{
		public static void CountFlipCoin()
		{
			Console.WriteLine("Welcome to flip coin program");
			Random random = new Random();
			bool flag = true;
			int head = 0;
			int tail = 1;
			int hcount = 0;
			int tcount = 0;
			while (flag)
			{
				Console.WriteLine("Flip the coin");
                int check = random.Next(0, 2);
                if (check==0)
				{
					Console.WriteLine("Head is present");
					hcount++;
					Console.WriteLine("Head count is " + hcount);
				}
				else
				{
					Console.WriteLine("Tail is Present");
					tcount++;
					Console.WriteLine("Tail count is " + tcount);
				}
				if (hcount >= 20)
				{
					flag = false;
				}
				else if (tcount >= 20)
				{
                    flag = false;
                }
				else
				{
					flag = true;
				}
			}
		}
	}
}
