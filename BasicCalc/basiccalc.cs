using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculator
    {
        static void Main()
        {
            // Welcoming the user and displaying options
            Console.Write("Welcome to Basic Calculator\n");
            Console.Write("Below are some functions you can choose:\n");
            Console.Write("Add, Sub, Multi, and Divide\n");

            // Seeking User Input
            Console.Write("What would you like to do? \n");
            string input = Console.ReadLine().ToLower();

            // Seeking User Input
            Console.Write("Please enter your first number:\n");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number:\n");
            int y = Convert.ToInt32(Console.ReadLine());

            /* Conditional checking for users Input
            * Then processing and displaying text to the Console*/

            if (input == "add"){
              int result = x + y;
              Console.Write("Result of {0} + {1} = {2}\n", x, y, result);
            }

            if (input == "sub"){
              int result = x - y;
              Console.Write("Result of {0} - {1} = {2}\n", x, y, result);
            }

            if (input == "multi"){
              int result = x * y;
              Console.Write("Result of {0} x {1} = {2}\n", x, y, result);
            }

            if (input == "divide"){
              int result = x/y;
              Console.Write("Result of {0} / {1} = {2}\n", x, y, result);
            }

            Console.Write("Would you like to do another calculation? [Y/N] \n");
            char restart = Convert.ToChar(Console.ReadLine().ToLower());
            if (restart == 'y'){
              Console.Clear();
              Main();
            }
            else {
              Console.Write("Thanks for using the Calculator. Good-bye.\n");
            }
        }
    }
}
