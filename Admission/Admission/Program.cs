using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntryTestScore;
            double userEntryGPA;
            Console.WriteLine("GPA? ");
            userEntryGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Test Score");
            userEntryTestScore = Convert.ToInt32(Console.ReadLine());

            if (userEntryGPA > 3.0 && userEntryTestScore > 60)
            {
                Console.WriteLine("Accepted into school");
            }
            else if (userEntryGPA < 3.0 && userEntryTestScore > 80)
            {
                Console.WriteLine("Accepted into school");
            }
            else
            {
                Console.WriteLine("You have been rejected in favor of someone with more money");
            }

        }
    }
}
