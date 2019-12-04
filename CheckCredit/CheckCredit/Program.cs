using System;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEnteredItemPrice;

            Console.WriteLine(" What is the price of the item that is being purchased? ");
            userEnteredItemPrice = Convert.ToInt32(Console.ReadLine());

            if (userEnteredItemPrice > 5000 )
            {
                Console.WriteLine("Item rejected from purchase");
            }
            else
            {
                Console.WriteLine("You good chief keep it up ");
            }

            
        }
    }
}
