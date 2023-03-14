using System;
namespace ProgramingConstructs_RFP267
{
	public class EligibilityForVote
	{
		public static void EligibilityForVoteFind()
		{
			Console.WriteLine("Enter the age ");
			int age = Convert.ToInt32(Console.ReadLine());
			if(age>18)
			{
				Console.WriteLine("You are eligible for Voting");
			}
			else
			{
				Console.WriteLine("You are not eligible for voting");
			}
		}
	}
}

