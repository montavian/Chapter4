using System;

namespace twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("Please enter your message");
            entry = Console.ReadLine();

            if (entry.Length <= 140)
            {
                Console.WriteLine("the length of your message is acceptible " + entry.Length);
            }
            else
            {
                Console.WriteLine("Message to Long " + entry.Length);
            }

        }
    }
}
