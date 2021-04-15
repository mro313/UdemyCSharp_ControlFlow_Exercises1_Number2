using System;


// 2- Write a program which takes two numbers from the console and displays the maximum of the two.

namespace Test
{

    class Program
    {
        static void Main(string[] args)

        {

            var firstNumberString = Console.ReadLine();
            int firstNumberInt = Convert.ToInt32(firstNumberString);

            var secondNumberString = Console.ReadLine();
            int secondNumberInt = Convert.ToInt32(secondNumberString);


            // Now we do the logic

            if (firstNumberInt > secondNumberInt)
            {
                Console.WriteLine(firstNumberInt);
            }

            else
            {
                Console.WriteLine(secondNumberInt);
            }
        }
    }
}
