using System.Globalization;
using Bookstore.Models;
using CsvHelper;

namespace BookstoreConsole
{
    internal class OutputHelper
    {
        public void WriteToConsole(List<Book> books)
        {
            Console.WriteLine("List of Books:");

            foreach (var book in books)
            {
                Console.WriteLine($"BookId: {book.BookId}    Title: {book.BookTitle}    Release Year: {book.YearOfRelease}");
            }
        }

        public void WriteToCSV(List<Book> books)
        {
            using (var writer = new StreamWriter(@"..\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }
    }
}
