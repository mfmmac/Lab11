using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class MovieList
    {
        public static List<Movie> ListOfMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Toy Story", "Animated"));
            movies.Add(new Movie("Monster Inc.", "Animated"));
            movies.Add(new Movie("Gladiator", "Drama"));
            movies.Add(new Movie("Moneyball", "Drama"));
            movies.Add(new Movie("The Predator", "Horror"));
            movies.Add(new Movie("The Silence of the Lambs", "Horror"));
            movies.Add(new Movie("The Shining", "Horror"));
            movies.Add(new Movie("Star Wars", "Scifi"));
            movies.Add(new Movie("Back to the Future", "Scifi"));
            movies.Add(new Movie("Star Trek", "Scifi"));
            return movies;
        }
        public static string UserCategoryChoice(int userInput)
        {
            if (userInput == 1)
            {
                Console.WriteLine("Animated:");
                return "Animated";
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Drama:");
                return "Drama";
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Horror:");
                return "Horror";
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Scifi:");
                return "Scifi";
            }
            else
            {
                Console.WriteLine("Invalid number");
                return "Invalid number";
            }
        }
        public static List<string> MovieListReturn(List<Movie> movies, int categoryUserChoice)
        {
            List<string> movieList = new List<string>();
            var category = UserCategoryChoice(categoryUserChoice);

            foreach (var movie in movies)
            {
                if (movie.Category == category)
                {
                    movieList.Add(movie.Title);
                }
            }
            return movieList;
        }
        public static StringBuilder AlphabeticalOrder(List<string> listOfMovies)
        {
            StringBuilder orderOfMovies = new StringBuilder();
            listOfMovies.Sort();
            foreach (var movie in listOfMovies)
            {
                orderOfMovies.Append($"{movie}\n");
            }
            return orderOfMovies;
        }
    }
}
