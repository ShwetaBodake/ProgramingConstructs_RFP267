using System;
namespace ProgramingConstructs_RFP267
{
	public class SumOfSquarsofNumbers
	{
		public static void SumOfSquarsofNumbersDisplay()
		{
			Console.WriteLine("Enter the  number");
			int num = Convert.ToInt32(Console.ReadLine());
			double totalsum = 0;
			for(int i=1;i<=num;i++)
			{
				double sum = Math.Pow(i, 2);
				totalsum += sum;
			}
			Console.WriteLine("Total sum of squars of numbers is:{0}", totalsum);
		}
	}
}

