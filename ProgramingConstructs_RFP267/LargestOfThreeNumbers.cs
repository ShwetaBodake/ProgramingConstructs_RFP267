using System;
namespace ProgramingConstructs_RFP267
{
	public class LargestOfThreeNumbers
	{
		public static void LargestOfThreeNumbersDisplay()
		{
			Console.WriteLine("Enter the first number");
			int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number");
            int Third = Convert.ToInt32(Console.ReadLine());
			if(first>Second & first > Third)
			{
				Console.WriteLine("First number is largest number among three numbers");
			}
			else if(Second>first & Second>Third)
			{
				Console.WriteLine("Second is the largest number");
			}
			else
			{
				Console.WriteLine("Third number is Largest");
			}
        }
	}
}

