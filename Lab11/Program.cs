using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        public static bool UserContinueSelection { get; private set; } = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie list application!");

            while (UserContinueSelection == true)
            {
                Console.WriteLine("What catagory are you interested in? (Please input 1-4 for your selection): \n" + "1. Animated\n" + "2. Drama\n" + "3. Horror\n" + "4. Scifi");

                var userInput = Console.ReadLine();

                if (Validator.ValidateUserInput(userInput, out var category ))
                {
                    var movieList = MovieList.MovieListReturn(MovieList.ListOfMovies(), category);

                    Console.WriteLine(MovieList.AlphabeticalOrder(movieList));

                    UserContinue();
                }
                else
                {
                    Console.WriteLine("Please input a number (1-4) for the catagory.");
                }
            }
        }
        private static void UserContinue()
        {
            Console.WriteLine("Do you want to continue? (Y/N)");
            var userContinue = Console.ReadLine();

            if (userContinue.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }
    }
}
