using System;
namespace ProgramingConstructs_RFP267
{
	public class EvenOddNumbers
	{
		public static void EvenOddNumbersDisplay()
		{
			Console.WriteLine("Eneter the number");
			int num = Convert.ToInt32(Console.ReadLine());
			if(num % 2==0)
			{
				Console.WriteLine("The givin number is EVEN");
			}
			else
			{
				Console.WriteLine("The givin number is ODD");
			}
		}
	}
}

