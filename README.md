# Pratik - IMDB Listesi

# IMDb Movie List Project

## Description
This project allows users to create and manage a list of movies along with their IMDb ratings. The user can add movies, filter them based on specific criteria, and display them accordingly.

## Features
- Add movies with a title and IMDb rating.
- Store movie data in a list.
- List all movies added by the user.
- Filter movies with IMDb ratings between 4 and 9.
- Display movies whose titles start with the letter 'A'.

## Data Structure
Each **Movie** is represented as an object with:
- **Title** (string): The name of the movie.
- **IMDbRating** (double): The IMDb rating of the movie.

## Class Breakdown
### **1. Movie Class**
Represents a movie with its title and IMDb rating.
```csharp
public class Movie
{
    public string Title { get; set; }
    public double IMDbRating { get; set; }
}
```
### **2. MovieManager Class**
Manages the list of movies, allowing users to add, list, and filter them.
```csharp
public class MovieManager
{
    private List<Movie> movies = new List<Movie>();

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

    public void ListAllMovies()
    {
        Console.WriteLine("\nAll Movies:");
        foreach (var movie in movies)
        {
            Console.WriteLine($"{movie.Title} - IMDb: {movie.IMDbRating}");
        }
    }

    public void ListFilteredMovies()
    {
        var filteredMovies = movies.Where(m => m.IMDbRating >= 4 && m.IMDbRating <= 9);

        Console.WriteLine("\nMovies with IMDb rating between 4 and 9:");
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine($"{movie.Title} - IMDb: {movie.IMDbRating}");
        }
    }

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
```
### **3. Program Class**
The main class that runs the program and calls the necessary methods.
```csharp
class Program
{
    static void Main()
    {
        MovieManager movieManager = new MovieManager();

        movieManager.AddMovies();
        movieManager.ListAllMovies();
        movieManager.ListFilteredMovies();
        movieManager.ListMoviesStartingWithA();
    }
}
```

## How to Run
1. Clone this repository or create a new Console Application in Visual Studio.
2. Add three separate files: `Movie.cs`, `MovieManager.cs`, and `Program.cs`.
3. Copy the corresponding code into each file.
4. Run the program and enter movie details when prompted.
5. The program will list movies and apply filters as required.

## Expected Output
```
Enter movie name: Inception
Enter IMDb rating: 8.8
Do you want to add another movie? (yes/no): yes
Enter movie name: Avatar
Enter IMDb rating: 7.9
Do you want to add another movie? (yes/no): no

All Movies:
Inception - IMDb: 8.8
Avatar - IMDb: 7.9

Movies with IMDb rating between 4 and 9:
Inception - IMDb: 8.8
Avatar - IMDb: 7.9

Movies starting with 'A':
Avatar - IMDb: 7.9
```

## Requirements
- .NET Core / .NET 5+
- Visual Studio or any C# compatible IDE
