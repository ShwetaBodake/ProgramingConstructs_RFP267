// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace ProgramingConstructs_RFP267
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to Programing Constructs------------");
            Console.WriteLine("Choose program from givin Option 1:Check numbers are equal are not\n 2:Display Even or Odd number\n " +
                "3:Find eligibility for Voting\n 4:Find largest number of three");

            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EqualityCheckOfInteger.EqualityOfInteger();
                    break;
                case 2:
                    EvenOddNumbers.EvenOddNumbersDisplay();
                    break;
                case 3:
                    EligibilityForVote.EligibilityForVoteFind();
                    break;
                case 4:
                    LargestOfThreeNumbers.LargestOfThreeNumbersDisplay();
                    break;
                default:
                    Console.WriteLine("Enter number within givin option");
                    break;
            }
        }
    }
}
