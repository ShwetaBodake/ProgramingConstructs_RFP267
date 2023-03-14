using System;
namespace ProgramingConstructs_RFP267
{
	public class EqualityCheckOfInteger
	{
		public static void EqualityOfInteger()
		{
			Console.WriteLine("Enter first number:");
			int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

			if(num1 ==num2)
			{
				Console.WriteLine("The givin two integer are equal");
			}
			else
			{
				Console.WriteLine("The givin two integers are not equal");
			}

        }
	}
}

