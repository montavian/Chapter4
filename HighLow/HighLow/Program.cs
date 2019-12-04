using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);
            Console.WriteLine("pleas inter a number between 9n and ten");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber)
            {
                Console.WriteLine("How did you know it was {0}?", userEntry);
            }
            else
            {
                Console.WriteLine("{0} that was incorrect. ", userEntry);
            }

        }
    }
}
