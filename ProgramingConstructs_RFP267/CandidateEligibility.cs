using System;
namespace ProgramingConstructs_RFP267
{
    public class CandidateEligibility
    {
        public static void TestCandidateEligibility()
        {
            Console.WriteLine("Enter the marks obtained in Mathematics");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Physics");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Chemistry");
            int chem = Convert.ToInt32(Console.ReadLine());
            int total = math + phy + chem;
            int mathphy = math + phy;
            int mathchem = math + chem;
            if(math>=65 && phy>=55 && chem>=50)
            {
                Console.WriteLine("Candidate is eligible for admission");
            }
            else if (total >= 180)
            {
                Console.WriteLine("Candidate is eligible for admission because total sum of all subject is greater than 180");
            }
            else if(mathphy >=140 || mathchem>= 140)
            {
                Console.WriteLine("Candidate is eligible for admission because  he got above 140 in one of two subject");
            }
        }
    }

}