using System;
namespace ProgramingConstructs_RFP267
{
	public class SumOfNaturalNumbers
	{
		public static void DieplaySumOfNaturalNumbers()
		{
            Console.WriteLine("The Sum of first 5 natural numbers ");
            int start = 1;
            int count = 1;
            int sum = 0;
            while (count <= 5)
            {
                sum = sum + start;
                count++;
                start++;
            }
            Console.WriteLine("Sum first 5 natural number is: " + sum);
        }
	}
}

