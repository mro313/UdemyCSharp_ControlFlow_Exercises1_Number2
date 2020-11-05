using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 2- Write a program which takes two numbers from the console and displays the maximum of the two.

namespace UdemyCSharp_ControlFlow_Exercises1_Number2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOne = 40;
            int numberTwo = 8;

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }

            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}
