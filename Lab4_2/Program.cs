using System;
using System.Collections.Generic;

namespace Lab4_2
{
    class MovieData
    {
        public string MovieCategory;
        public string MovieName;

        public MovieData(string cat, string name)
            {

            MovieCategory = cat;
            MovieName = name;

            }
  
    }
        

    class Program
{

    static void Main(string[] args)
    {
            bool moreMovies, validYN;
            string userContinue;

            Console.WriteLine("There are 15 movies in this list.\n");

            do
            {
                List<MovieData> movies = new List<MovieData>();
                movies.Add(new MovieData("SciFi", "Star Wars"));
                movies.Add(new MovieData("SciFi", "Aliens"));
                movies.Add(new MovieData("SciFi", "Terminator"));
                movies.Add(new MovieData("SciFi", "Star Trek: First Contact"));
                movies.Add(new MovieData("SciFi", "Avengers"));
                movies.Add(new MovieData("Drama", "Life as A House"));
                movies.Add(new MovieData("Drama", "Steel Magnolias"));
                movies.Add(new MovieData("Drama", "Judas and the Black Messiah"));
                movies.Add(new MovieData("Drama", "Glory"));
                movies.Add(new MovieData("Drama", "Good Fellas"));
                movies.Add(new MovieData("Horror", "Scream"));
                movies.Add(new MovieData("Horror", "Nightmare on Elm Street"));
                movies.Add(new MovieData("Horror", "Human Centipede"));
                movies.Add(new MovieData("Horror", "It Follows"));
                movies.Add(new MovieData("Horror", "Good Burger"));

                

                Console.WriteLine("\nWhat category are you interested in? (SciFi, Drama or Horror)");
                string movieType = Console.ReadLine();

                foreach (MovieData movie in movies)
                {
                    if (movie.MovieCategory.Equals(movieType,StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(movie.MovieName);
                    }

                }

                do
                {
                    Console.Write("\nContinue? (y/n): ");
                    userContinue= Console.ReadLine();

                    validYN = userContinue.Equals("y", StringComparison.OrdinalIgnoreCase) || userContinue.Equals("n", StringComparison.OrdinalIgnoreCase);
            
                } while (!validYN);

                moreMovies = userContinue.Equals("y", StringComparison.OrdinalIgnoreCase);
                
            } while (moreMovies);
    }
}

}