using Pratik___IMDB_Listesi;

class Program
{
    static void Main()
    {
        MovieManager movieManager = new MovieManager();

        // Kullanıcıdan film bilgilerini al
        movieManager.AddMovies();

        // Filmleri listele
        movieManager.ListAllMovies();

        // IMDb puanı 4-9 arasındaki filmleri listele
        movieManager.ListFilteredMovies();

        // "A" harfiyle başlayan filmleri listele
        movieManager.ListMoviesStartingWithA();
    }
}
