using System;
namespace ProgramingConstructs_RFP267
{
	public class ReverseString
	{
		public static void ReverseStringDisplay()
		{
			Console.WriteLine("Enter the word");
			string word = Console.ReadLine();
			Console.WriteLine("Word after Reversing");
			char[] array = word.ToCharArray();
			for(int i=word.Length-1;i>=0;i--)
			{
				Console.Write(array[i]);
			}
		}
	}
}

