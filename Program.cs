using System;
using System.Collections.Generic;
using System.Linq;

class Movie
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        var movies = new List<Movie>
        {
            new Movie { Name = "Фільм 1", Author = "Автор 1", Year = 2005, Category = "Фентезі" },
            new Movie { Name = "Фільм 2", Author = "Автор 2", Year = 2010, Category = "Фентезі" },
            new Movie { Name = "Фільм 3", Author = "Автор 3", Year = 2003, Category = "Фентезі" },
            new Movie { Name = "Фільм 4", Author = "Автор 4", Year = 2011, Category = "Фентезі" },
            new Movie { Name = "Фільм 5", Author = "Автор 5", Year = 2015, Category = "Драма" },
            new Movie { Name = "Фільм 6", Author = "Автор 6", Year = 2008, Category = "Фентезі" },
            new Movie { Name = "Фільм 7", Author = "Автор 7", Year = 2002, Category = "Комедія" },
            new Movie { Name = "Фільм 8", Author = "Автор 8", Year = 2006, Category = "Фентезі" },
            new Movie { Name = "Фільм 9", Author = "Автор 9", Year = 2007, Category = "Фентезі" },
            new Movie { Name = "Фільм 10", Author = "Автор 10", Year = 2013, Category = "Фентезі" }
        };

        var selectedMovies = movies
            .Where(m => m.Category == "Фентезі" && m.Year > 2000 && m.Year < 2012)
            .OrderBy(m => m.Year)
            .ToList();

        var earliestMovie = selectedMovies.FirstOrDefault();
        Console.WriteLine("Найраніший фільм:");
        if (earliestMovie != null)
            Console.WriteLine($"{earliestMovie.Name}, {earliestMovie.Year}");
        else
            Console.WriteLine("Фільмів не знайдено.");
    }
}
