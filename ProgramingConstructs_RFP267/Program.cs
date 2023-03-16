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
                "3:Find eligibility for Voting\n 4:Find largest number of three\n " +
                "5:Calculate weekdayy name by giving week number\n 6:Arithmatic operations\n 7:Power of two table value" +
                "\n8:Sum of Squars of number \n9:Factorial Number \n10:Rverse the givin word \n11:Flip Coin Program");

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
                case 5:
                    CalculateWeekdayName weekdayName = new CalculateWeekdayName();
                    weekdayName.CalculateWeekdayNameDisplay();
                    break;
                case 6:
                    ArithmaticOperations arithmaticOperations = new ArithmaticOperations();
                    arithmaticOperations.PerformArithmaticOperations();
                    break;
                case 7:
                    PowerOfTwo.PowerOfTwoDisplay();
                    break;
                case 8:
                    SumOfSquarsofNumbers.SumOfSquarsofNumbersDisplay();
                    break;
                case 9:
                    FactorialNumber.FactorialNumberdisplay();
                    break;
                case 10:
                    ReverseString.ReverseStringDisplay();
                    break;
                case 11:
                    FlipCoin.CountFlipCoin();
                    break;
                default:
                    Console.WriteLine("Enter number within givin option");
                    break;
            }
        }
    }
}
