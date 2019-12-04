using System;

namespace compareThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Enter a integer >>> ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a integer >>> ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a integer >>> ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("All three numbers are equal. ");
                }
                else
                {
                    Console.WriteLine(" Hey guy your an idiot baka stupido head only num1 and num2 are equal. ");
                }

            }
             else if (num1 == num2)
             {
                Console.WriteLine("First and last are equal. ");
             }
             else if (num2 == num3)
             {
                Console.WriteLine("Last two numbers are equal. ");
             }
             else
             {
                Console.WriteLine("No two numbers are equal. ");
             }


        }  






    }
}
