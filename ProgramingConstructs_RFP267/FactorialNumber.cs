using System;
namespace ProgramingConstructs_RFP267
{
	public class FactorialNumber
	{
		public static void FactorialNumberdisplay()
		{
			int fact = 1;
			Console.WriteLine("Enter the number");
			int num = Convert.ToInt32(Console.ReadLine());
			for(int i=1;i<=num;i++)
			{
				fact = fact * i;
			}
            Console.WriteLine("The factorial of givin number is {0}", fact);
        }
	}
}

