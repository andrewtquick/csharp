using System;

// Namespace
namespace NumberGuesser

{   // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run get app info function
            GetAppInfo();
            GreetUser();

            while (true)
            {

                // Init correct number
                // int correctNumber = 7;

                // Create random number

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string userGuess = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(userGuess, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Parse user input to guess variable
                    guess = Int32.Parse(userGuess);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "Wrong number. Try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "CORRECT! You guessed the number!");
                // Ask to play again
                Console.WriteLine("Would you like to play again? [Y/N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andrew Quick";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset console color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?:");

            // Get user input
            string playerName = Console.ReadLine();

            // Greet user
            Console.WriteLine("Hello {0}, let's play a game.", playerName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user input is not an integer
            Console.WriteLine(message);

            // Reset Console Color
            Console.ResetColor();
        }
    }
}
