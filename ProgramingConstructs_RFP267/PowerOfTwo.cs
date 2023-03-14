using System;
namespace ProgramingConstructs_RFP267
{
	public class PowerOfTwo
	{
		public static void PowerOfTwoDisplay()
		{
			Console.WriteLine("Enter the number n");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The table of power of two is:");
			for(int i=0;i<=num;i++)
			{
				double power = Math.Pow(2,i);
				Console.WriteLine(power);
			}
		}
	}
}

