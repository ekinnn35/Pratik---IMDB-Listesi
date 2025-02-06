using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik___IMDB_Listesi
{
    public class MovieManager
    {
        private List<Movie> movies = new List<Movie>();

        // Kullanıcıdan film bilgilerini alma
        public void AddMovies()
        {
            while (true)
            {
                Console.Write("Enter movie name: ");
                string title = Console.ReadLine();

                Console.Write("Enter IMDb rating: ");
                double rating;
                while (!double.TryParse(Console.ReadLine(), out rating))
                {
                    Console.Write("Invalid input! Please enter a valid IMDb rating: ");
                }

                movies.Add(new Movie { Title = title, IMDbRating = rating });

                Console.Write("Do you want to add another movie? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                if (response != "yes")
                    break;
            }
        }

        // Tüm filmleri listeleme
        public void ListAllMovies()
        {
            Console.WriteLine("\nAll Movies:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} - IMDb: {movie.IMDbRating}");
            }
        }

        // IMDb puanı 4 ile 9 arasındaki filmleri listeleme
        public void ListFilteredMovies()
        {
            var filteredMovies = movies.Where(m => m.IMDbRating >= 4 && m.IMDbRating <= 9);

            Console.WriteLine("\nMovies with IMDb rating between 4 and 9:");
            foreach (var movie in filteredMovies)
            {
                Console.WriteLine($"{movie.Title} - IMDb: {movie.IMDbRating}");
            }
        }

        // "A" harfiyle başlayan filmleri listeleme
        public void ListMoviesStartingWithA()
        {
            var moviesStartingWithA = movies.Where(m => m.Title.StartsWith("A", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nMovies starting with 'A':");
            foreach (var movie in moviesStartingWithA)
            {
                Console.WriteLine($"{movie.Title} - IMDb: {movie.IMDbRating}");
            }
        }
    }

}
