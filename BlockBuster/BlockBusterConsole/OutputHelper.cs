using System.Globalization;
using BlockBuster.Models;
using CsvHelper;

namespace BlockBusterConsole
{
    internal class OutputHelper
    {
        public void WriteToConsole(List<Movie> movies)
        {
            Console.WriteLine("List of Movies:");

            foreach (var movie in movies)
            {
                Console.WriteLine($"MovieId: {movie.MovieId}    Title: {movie.Title}    Release Year: {movie.ReleaseYear}");
            }
        }

        public void WriteToCSV(List<Movie> movies)
        {
            using (var writer = new StreamWriter(@"..\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(movies);
            }
        }
    }
}
