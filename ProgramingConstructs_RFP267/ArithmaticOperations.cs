using System;
namespace ProgramingConstructs_RFP267
{
	public class ArithmaticOperations
	{
		public void PerformArithmaticOperations()
		{
			Console.WriteLine("Enter the first number");
			int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Choose the option which arithmatic opertaion you want to perform:\n1:Addition\n2:Subtraction\n3:multiplication\n 4:Division");
			int option = Convert.ToInt32(Console.ReadLine());
			switch(option)
			{
				case 1:
					int addition = num1 + num2;
					Console.WriteLine("Adition of two number is {0}", addition);
					break;
                case 2:
                    int subtraction = num1 - num2;
                    Console.WriteLine("Adition of two number is {0}", subtraction);
                    break;
                case 3:
                    int multiplication = num1 * num2;
                    Console.WriteLine("Adition of two number is {0}", multiplication);
                    break;
                case 4:
                    int divison = num1 / num2;
                    Console.WriteLine("Adition of two number is {0}", divison);
                    break;
                default:
                    Console.WriteLine("Enter option within range");
                    break;

            }

        }
	}
}

