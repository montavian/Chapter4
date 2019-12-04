using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            double userEnteredWindSpeed;

            Console.WriteLine("What is the Aproximate wind speed of the storm in your area");
            userEnteredWindSpeed = Convert.ToDouble(Console.ReadLine());

            if (userEnteredWindSpeed <= 73 )
            {
                Console.WriteLine("That aint no storm cheif.");
            }
            if (userEnteredWindSpeed >= 74 && userEnteredWindSpeed <= 96 )
            {
                Console.WriteLine("Thats a stage one just make sure you have a candel light or something.");
            }
            if (userEnteredWindSpeed >= 97 && userEnteredWindSpeed <= 111 )
            {
                Console.WriteLine("Thats a stage 2, you might want to think about moving because I can assure " +
                    "you that the wind will.");
            }
            if (userEnteredWindSpeed >= 112 && userEnteredWindSpeed <= 130 )
            {
                Console.WriteLine("Thats a stage 3, hope you have home, boat, car, and life insurrance because they gone now.");
            }
            if (userEnteredWindSpeed >= 131 && userEnteredWindSpeed <= 157 )
            {
                Console.WriteLine("You have been lost to a stage 4 better luck next time");
            }
            else if (userEnteredWindSpeed > 157 )
            {
                Console.WriteLine("how are you alive right now?");
            }
               
        }
    }
}
