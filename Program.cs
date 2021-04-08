using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andrea";

            Console.ForegroundColor = ConsoleColor.Green;

            //Write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Ask for input
            Console.WriteLine("What is Your Name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

            // Init correct number
            int correctNumber = 7;

            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WRONG!! {0} is not a number. Please enter a number..", input);
                    Console.ResetColor();
                    continue;
                }
                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is not the correct number. Please try again.", input);
                    Console.ResetColor();
                    Console.WriteLine("Guess a number between 1 and 10");
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Great Job {0}! {1} is the correct Number!", inputName, guess);
            Console.ResetColor();


        }
    }
}
