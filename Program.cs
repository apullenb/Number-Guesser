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


        }
    }
}
